using SimulacionTP3.Modelo;
using SimulacionTP3.Modelo.Distribuciones;
using SimulacionTP3.Presentacion.FormulariosPadre;
using SimulacionTP3.Servicios.GestoresPruebaBondad;
using System;

namespace SimulacionTP3.Servicios.GestoresGenerador
{
    public abstract class GestorGenerador
    {
        private readonly FrmGenerador formulario;
        private readonly Generador generador;
        private double[] serie;
        private ConteoFrecuencia[] conteos;
        private int intervalos, cantidad;

        protected abstract double[] GenerarSerie(Generador generador, int cantidad);
        protected abstract void PedirDatos();
        protected abstract void ValidarDatos();
        protected abstract IDistribucion GetDistribucion();


        public GestorGenerador(FrmGenerador formulario)
        {
            this.formulario = formulario;
            generador = new Generador();
        }

        public void Generar()
        {
            try
            {
                formulario.HabilitarPrueba(false);

                intervalos = formulario.GetIntervalos();
                cantidad = formulario.GetCantidad();
                PedirDatos();
                Validar();

                serie = GenerarSerie(generador, cantidad);
                ConteoFrecuencias();
                
                formulario.Limpiar();
                MostrarGrafico();
                formulario.MostrarSerie(MostrarSerie());

                formulario.HabilitarPrueba(true);
            }
            catch (Exception ex)
            {
                formulario.MostrarError(ex);
            }
        }

        private void Validar()
        {
            ValidarDatos();

            if (cantidad <= 1)
                throw new ApplicationException("Ingresar una cantidad mayor que uno.");
        }

        private void MostrarGrafico()
        {
            foreach (ConteoFrecuencia conteo in conteos)
                formulario.MostrarGrafico(
                    Math.Round(conteo.Hasta, 4),
                    conteo.Cantidad
                    );
        }

        private string MostrarSerie()
        {
            string serieStr = "";
            for (int i = 0; i < cantidad; i++)
            {
                serieStr += Math.Round(serie[i], 4).ToString();
                serieStr += "\t";
            }
            return serieStr;
        }

        /* 
         * Realiza el conteo de frecuencias con dos pasadas sobre la serie de números aleatorios,
         * organizándolos en un array de ConteoFrecuencia.
         * 
         * En la primera pasada se identifican el mayor y menor valor.
         * En la segunda se identifica el intervalo a incrementar, contando en los objetos ConteoFrecuencia.
         * Para determinar el intervalo (posición en el array) se utiliza las siguientes fórmulas:
         * 
         * posicion (p): 0, 1, 2, 3 ...
         * serie { d [double] / min <= d <= max }
         * anchoIntervalo (t) = (max - min) / 2
         * 
         * d = min + t * p     se despeja la posición
         * p = d/t - min/t
         * 
         * p = Truncar( A * d + B )       donde: A = 1/t   B = -min/t
         * 
         */
        private void ConteoFrecuencias()
        {
            int posicion;
            double anchoIntervalo, mayor, menor, inicioIntervalo, A, B;

            if (intervalos == 0)
                intervalos = (int) Math.Sqrt(cantidad);

            mayor = menor = serie[0];

            foreach (double d in serie)
            {
                if (d < menor) menor = d;
                if (d > mayor) mayor = d;
            }

            anchoIntervalo = (mayor - menor) / intervalos;
            conteos = new ConteoFrecuencia[intervalos];

            for (int i = 0; i < intervalos; i++)
            {
                inicioIntervalo = menor + i * anchoIntervalo;

                conteos[i] = new ConteoFrecuencia
                {
                    Desde = inicioIntervalo,
                    Hasta = inicioIntervalo + anchoIntervalo,
                    Cantidad = 0
                };
            }

            A = 1 / anchoIntervalo;
            B = -menor / anchoIntervalo;

            foreach (double d in serie)
            {
                posicion = (int) (A * d + B);

                // para incluir el valor mayor y evitar errores
                if (posicion >= intervalos)
                    posicion = intervalos - 1;

                conteos[posicion].Contar();
            }
        }

        public void Limpiar()
        {
            formulario.Limpiar();
        }

        public void ProbarGenerador()
        {
            GestorPruebaBondad pruebaBondad = new GestorPruebaBondad();
            pruebaBondad.SetDistribucion(GetDistribucion());
            pruebaBondad.CalcularPrueba(serie, conteos);
        }
    }
}
