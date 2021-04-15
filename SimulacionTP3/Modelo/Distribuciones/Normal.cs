using System;

namespace SimulacionTP3.Modelo.Distribuciones
{
    public class Normal : Distribucion
    {
        public override double[] CalcularFrecuenciasEsperadas(double[] serie, ConteoFrecuencia[] conteos)
        {
            int k, n;
            double desviacion, media, exponente, marcaClase, anchoIntervalo, denominador;
            double[] frecuencias;

            media = CalcularMedia(serie);
            desviacion = CalcularDesviacion(media, serie);
            k = conteos.Length;
            n = serie.Length;
            frecuencias = new double[k];
            anchoIntervalo = conteos[0].Hasta - conteos[0].Desde;
            denominador = desviacion * Math.Sqrt(2 * Math.PI);

            for (int i = 0; i < k; i++)
            {
                marcaClase = (conteos[i].Desde + conteos[i].Hasta) / 2;
                exponente = -0.5 * Math.Pow((marcaClase - media)/desviacion, 2);
                frecuencias[i] = n * anchoIntervalo * Math.Exp(exponente) / denominador;
            }
            return frecuencias;
        }

        private double CalcularMedia(double[] serie)
        {
            double suma, n;
            suma = 0;
            n = serie.Length;

            foreach (double d in serie)
                suma += d;

            return suma / n;
        }

        private double CalcularDesviacion(double media, double[] serie)
        {
            double suma, n;
            suma = 0;
            n = serie.Length;

            foreach (double d in serie)
                suma += Math.Pow(d - media, 2);

            return Math.Sqrt(suma / (n - 1));
        }

        public override string GetNombre()
        {
            return "Normal";
        }

        public override int CantidadDatosEmpiricos()
        {
            return 2;
        }    
    }
}
