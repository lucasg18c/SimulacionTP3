using System;

namespace SimulacionTP3.Modelo
{
    public class Generador
    {
        private double[] serie;
        private readonly Random r;

        public Generador()
        {
            r = new Random();
        }

        public double[] GenerarUniforme(double a, double b, int cantidad)
        {
            serie = new double[cantidad];
            double ancho = b - a;

            for (int i = 0; i < cantidad; i++)
                serie[i] = a + r.NextDouble() * ancho;

            return serie;
        }

        public double[] GenerarExponencial(double media, int cantidad)
        {
            serie = new double[cantidad];
            media *= -1;

            for (int i = 0; i < cantidad; i++)
                serie[i] = media * Math.Log(1 - r.NextDouble());

            return serie;
        }

        public double[] GenerarPoisson(double media, int cantidad)
        {
            double p, x, a;

            serie = new double[cantidad];
            a = Math.Exp(-media);

            for (int i = 0; i < cantidad; i++)
            {
                p = 1;
                x = -1;

                do
                {
                    p *= r.NextDouble();
                    x++;

                } while (p >= a);

                serie[i] = x;
            }

            return serie;
        }

        public double[] GenerarNormalBM(double media, double desviacion, int cantidad)
        {
            double temp1, temp2, dosPI;
            int iteraciones;

            serie = new double[cantidad];
            dosPI = 2 * Math.PI;
            iteraciones = cantidad % 2 == 0 ? cantidad : cantidad - 1;

            for (int i = 0; i < iteraciones; i += 2)
            {
                temp1 = Math.Sqrt(-2 * Math.Log(r.NextDouble()));
                temp2 = dosPI * r.NextDouble();

                serie[i] = temp1 * Math.Cos(temp2) * desviacion + media;
                serie[i + 1] = temp1 * Math.Sin(temp2) * desviacion + media;
            }

            if (cantidad % 2 == 1)
                serie[cantidad - 1] = Math.Sqrt(-2 * Math.Log(r.NextDouble())) * Math.Cos(dosPI * r.NextDouble()) * desviacion + media;
            
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
                    suma += r.NextDouble();

                serie[i] = suma * desviacion + media;
            }
            return serie;
        }
    }
}
