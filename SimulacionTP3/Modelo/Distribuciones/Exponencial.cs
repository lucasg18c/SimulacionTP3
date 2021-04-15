using System;

namespace SimulacionTP3.Modelo.Distribuciones
{
    public class Exponencial : Distribucion
    {
        public override double[] CalcularFrecuenciasEsperadas(double[] serie, ConteoFrecuencia[] conteos)
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

        public override string GetNombre()
        {
            return "Exponencial";
        }

        public override int CantidadDatosEmpiricos()
        {
            return 1;
        }
    }
}
