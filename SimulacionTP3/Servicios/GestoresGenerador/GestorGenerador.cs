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
        private Distribucion distribucion;

        protected abstract double[] GenerarSerie(Generador generador, int cantidad);
        protected abstract void PedirDatos();
        protected abstract void ValidarDatos();
        protected abstract Distribucion GetDistribucion();

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
                distribucion = GetDistribucion();
                PedirDatos();
                Validar();

                serie = GenerarSerie(generador, cantidad);
                conteos = ContadorFrecuencias.Contar(serie, intervalos, distribucion.IntervalosEnteros());

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

        public void Limpiar()
        {
            formulario.Limpiar();
        }

        public void ProbarGenerador()
        {
            try
            {
                new GestorPruebaBondad(serie, conteos, distribucion).CalcularPrueba();
            }
            catch(ApplicationException ex)
            {
                formulario.MostrarError(ex);
            }
            catch(Exception)
            {
                //formulario.MostrarError(ex);
                formulario.MostrarError("Ocurrió un error al calcular la prueba de bondad." +
                    "\nPor favor, utilice un tamaño de muestra diferente.");
            }
        }
    }
}
