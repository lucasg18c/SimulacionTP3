using System;

namespace SimulacionTP3.Modelo
{
    public class Generador
    {
        private double[] serie;
        private readonly Random random;

        public Generador()
        {
            random = new Random();
        }

        public double[] GenerarUniforme(double a, double b, int cantidad)
        {
            serie = new double[cantidad];

            for (int i = 0; i < cantidad; i++)
                serie[i] = a + random.NextDouble() * (b - a);

            return serie;
        }

        public double[] GenerarExponencial()
        {
            return null;
        }
        public double[] GenerarPoisson()
        {
            return null;
        }
        public double[] GenerarNormalBM()
        {
            return null;
        }
        public double[] GenerarNormalConvolucion()
        {
            return null;
        }
    }
}
