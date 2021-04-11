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

        public double[] GenerarExponencial(double media, double frecuencia, int cantidad)
        {
            double multiplicar = media == 0 ? (-1 / frecuencia) : -media;
            serie = new double[cantidad];

            for (int i = 0; i < cantidad; i++)
                serie[i] = multiplicar * Math.Log(1 - random.NextDouble());

            return serie;
        }

        public double[] GenerarPoisson(double frecuencia, int cantidad)
        {
            double p, x, a;

            serie = new double[cantidad];
            a = Math.Exp(-frecuencia);

            for (int i = 0; i < cantidad; i++)
            {
                p = 1;
                x = -1;

                do
                {
                    p *= random.NextDouble();
                    x++;

                } while (p >= a);

                serie[i] = x;
            }

            return serie;
        }

        public double[] GenerarNormalBM(double media, double desviacion, int cantidad)
        {
            double rnd1, rnd2, n1, n2, temp1, temp2;
            serie = new double[cantidad];

            for (int i = 0; i < cantidad; i += 2)
            {
                rnd1 = random.NextDouble();
                rnd2 = random.NextDouble();

                temp1 = Math.Sqrt(-2 * Math.Log(rnd1));
                temp2 = 2 * Math.PI * rnd2;

                n1 = temp1 * Math.Cos(temp2) * desviacion + media;
                n2 = temp1 * Math.Sin(temp2) * desviacion + media;

                serie[i] = n1;
                if (i + 1 < cantidad)
                    serie[i + 1] = n2;
            }
            return serie;
        }

        public double[] GenerarNormalConvolucion(double media, double desviacion, int cantidad)
        {
            double suma;

            serie = new double[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                suma = -6;
                for (int j = 0; j < 12; j++)
                    suma += random.NextDouble();

                serie[i] = suma * desviacion + media;
            }

            return serie;
        }
    }
}
