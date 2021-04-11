using System;

namespace SimulacionTP3.Modelo.Generadores
{
    public abstract class GeneradorBase
    {
        public abstract double[] Generar(int cantidad, double media, double frecuencia);

        protected double[] GenerarUniforme(int cantidad)
        {
            double[] numeros = new double[cantidad];
            Random r = new Random();

            for (int i = 0; i < cantidad; i++)
                numeros[i] = r.NextDouble();

            return numeros;
        }
    }
}
