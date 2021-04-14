using SimulacionTP3.Modelo.PruebasBondad;
using System;

namespace SimulacionTP3.Modelo.Distribuciones
{
    public class Poisson : IDistribucion
    {
        public double[] CalcularFrecuenciasEsperadas(double[] serie, ConteoFrecuencia[] conteos)
        {
            int marcaClase, anchoIntervalo, media, k, n;
            double[] frecuencias;

            k = conteos.Length;
            n = serie.Length;
            media = CalcularMedia(serie);
            frecuencias = new double[k];
            anchoIntervalo = (int) (conteos[0].Hasta - conteos[0].Desde);

            for (int i = 0; i < k; i++)
            {
                marcaClase = (int) ((conteos[i].Hasta + conteos[i].Desde) / 2);
                frecuencias[i] = (int) (n * anchoIntervalo * Math.Pow(media, marcaClase) * Math.Exp(-media) / Factorial(marcaClase));
            }
            return frecuencias;
        }

        private int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        private int CalcularMedia(double[] serie)
        {
            int n, suma;

            n = serie.Length;
            suma = 0;

            for (int i = 0; i < n; i++)
                suma += (int) serie[i];
            return suma / n;
        }

        public string GetNombre()
        {
            return "Poisson";
        }

        public int GetDatosEmpiricos()
        {
            return 1;
        }

        public IPruebaBondad ElegirPruebaBondad(int tamanioMuestra)
        {
            return new PruebaChiCuadrado();
        }
    }
}
