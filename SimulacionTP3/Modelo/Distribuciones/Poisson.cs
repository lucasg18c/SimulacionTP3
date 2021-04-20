using SimulacionTP3.Modelo.PruebasBondad;
using System;

namespace SimulacionTP3.Modelo.Distribuciones
{
    public class Poisson : Distribucion
    {
        public override double[] CalcularFrecuenciasEsperadas(double[] serie, ConteoFrecuencia[] conteos)
        {
            int media, k, n;
            double[] frecuencias;

            k = conteos.Length;
            n = serie.Length;
            media = CalcularMedia(serie);
            frecuencias = new double[k];

            for (int i = 0; i < k; i++)
            {
                frecuencias[i] = n * Math.Pow(media, conteos[i].Desde) * Math.Exp(-media) / Factorial(conteos[i].Desde);
            }
            return frecuencias;
        }

        private double Factorial(double n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        private int CalcularMedia(double[] serie)
        {
            double n, suma;

            n = serie.Length;
            suma = 0;

            for (int i = 0; i < n; i++)
                suma += (int) serie[i];
            return (int) Math.Round(suma / n);
        }

        public override string GetNombre()
        {
            return "Poisson";
        }

        public override bool IntervalosEnteros()
        {
            return true;
        }

        public override int CantidadDatosEmpiricos()
        {
            return 1;
        }

        public override PruebaBondad ElegirPruebaBondad(int tamanioMuestra)
        {
            return new PruebaChiCuadrado();
        }
    }
}
