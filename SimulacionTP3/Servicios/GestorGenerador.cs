using SimulacionTP3.Modelo;
using SimulacionTP3.Modelo.Distribuciones;
using SimulacionTP3.Presentacion.FormulariosPadre;
using System;

namespace SimulacionTP3.Servicios
{
    public abstract class GestorGenerador
    {
        private readonly FrmGenerador formulario;
        private readonly Generador generador;
        private double[] serie;
        private ConteoFrecuencia[] conteo;
        private int intervalos, cantidad;

        protected abstract double[] GenerarSerie(Generador generador, int cantidad);
        protected abstract void PedirDatos();
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
                intervalos = formulario.GetIntervalos();
                cantidad = formulario.GetCantidad();
                PedirDatos();
                serie = GenerarSerie(generador, cantidad);
                ConteoFrecuencias();
                
                formulario.Limpiar();
                formulario.MostrarGrafico(conteo);
                formulario.MostrarSerie(MostrarSerie());
            }
            catch(Exception ex)
            {
                formulario.MostrarError(ex);
            }
        }

        private string MostrarSerie()
        {
            string serieStr = "";
            for (int i = 0; i < cantidad; i++)
            {
                serieStr += Math.Round(serie[i], 4).ToString();
                if (i < cantidad - 1)
                    serieStr += " - ";
            }

            return serieStr;
        }

        // TODO: ARREGLAR
        private void ConteoFrecuencias()
        {
            int posicion;
            double anchoIntervalo, mayor, menor, inicioIntervalo;

            if (intervalos == 0)
                intervalos = (int) Math.Sqrt(cantidad);

            mayor = menor = serie[0];

            foreach (double d in serie)
            {
                if (d < menor) menor = d;
                if (d > mayor) mayor = d;
            }
            menor = Math.Truncate(menor);
            mayor = Math.Ceiling(mayor);

            anchoIntervalo = (mayor - menor) / intervalos;

            if (anchoIntervalo * intervalos < menor)
            {
                menor = (menor + anchoIntervalo * intervalos) / 2;
                anchoIntervalo = (mayor - menor) / intervalos;
            }

            conteo = new ConteoFrecuencia[intervalos];

            for (int i = 0; i < intervalos; i++)
            {
                inicioIntervalo = menor + i * anchoIntervalo;

                conteo[i] = new ConteoFrecuencia
                {
                    Desde = inicioIntervalo,
                    Hasta = inicioIntervalo + anchoIntervalo,
                    Cantidad = 0
                };
            }

            foreach (double d in serie)
            {
                posicion = (int)(d / anchoIntervalo);
                //Console.WriteLine($"min: {menor} may: {mayor} d: {d}  ancho: {anchoIntervalo}  cantida intervalos: {intervalos}  pos: {posicion}");
                if (posicion >= intervalos)
                    posicion -= intervalos;
                conteo[posicion].Contar();
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
            pruebaBondad.CalcularPrueba(serie, conteo);
        }
    }
}
