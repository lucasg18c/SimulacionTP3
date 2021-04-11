using SimulacionTP3.Formularios;
using SimulacionTP3.Modelo.Generadores;
using System;

namespace SimulacionTP3.Servicios
{
    public class GestorExponencial
    {
        private FrmExponencial formulario;
        private GeneradorBase generador;
        private static readonly int DECIMALES_REDONDEO = 4;

        public GestorExponencial(FrmExponencial formulario)
        {
            this.formulario = formulario;
            generador = new GeneradorExponencial();
        }

        public void Generar()
        {
            try
            {
                double media, frecuencia, cantidad;
                double[] serie;

                media = formulario.GetMedia();
                frecuencia = formulario.GetFrecuencia();
                cantidad = formulario.GetCantidad();

                Validar(media, frecuencia, cantidad);

                serie = generador.Generar((int)cantidad, media, frecuencia);

                formulario.MostrarTabla(FormatearSerie(serie));
            }
            catch (Exception ex)
            {
                formulario.MostrarError(ex.Message);
            }
        }

        private string[] FormatearSerie(double[] serie)
        {
            string[] numeros = new string[serie.Length];

            for (int i = 0; i < serie.Length; i++)
                numeros[i] = Math.Round(serie[i], DECIMALES_REDONDEO).ToString();

            return numeros;
        }

        private void Validar(double media, double frecuencia, double cantidad)
        {
            if (double.IsNaN(media))
                throw new ApplicationException("El valor de la media no es válido.");

            if (double.IsNaN(frecuencia))
                throw new ApplicationException("El valor de la frecuencia no es válido.");

            if (double.IsNaN(cantidad))
                throw new ApplicationException("La cantidad no es válida.");
        }
    }
}
