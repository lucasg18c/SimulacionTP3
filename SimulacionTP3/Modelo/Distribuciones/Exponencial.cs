using SimulacionTP3.Modelo.PruebasBondad;
using System;

namespace SimulacionTP3.Modelo.Distribuciones
{
    public class Exponencial : IDistribucion
    {
        public double[] CalcularFrecuenciasEsperadas(double[] serie, ConteoFrecuencia[] conteos)
        {
            int k, n;
            double desde, hasta;

            k = conteos.Length;
            n = serie.Length;

            double[] frecuencias = new double[k];
            double lambda = CalcularLambda(serie);

            for (int i = 0; i < k; i++)
            {
                desde = 1 - Math.Exp(-lambda * conteos[i].Desde);
                hasta = 1 - Math.Exp(-lambda * conteos[i].Hasta);
                frecuencias[i] = n * (hasta - desde);
            }
            return frecuencias;
        }

        private double CalcularLambda(double[] serie)
        {
            double suma = 0;
            foreach (double d in serie)
                suma += d;

            suma /= serie.Length;
            return 1 / suma;
        }

        public string GetNombre()
        {
            return "Exponencial";
        }

        public int GetDatosEmpiricos()
        {
            return 1;
        }

        public IPruebaBondad ElegirPruebaBondad(int tamanioMuestra)
        {
            if (tamanioMuestra >= 30)
                return new PruebaChiCuadrado();
            else
                return new PruebaKS();
        }
    }
}
