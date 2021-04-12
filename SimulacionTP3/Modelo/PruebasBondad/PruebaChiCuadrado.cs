using System;

namespace SimulacionTP3.Modelo.PruebasBondad
{
    public class PruebaChiCuadrado : IPruebaBondad
    {
        private static readonly double[] valoresCriticos = {
            3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7,
            21.0, 22.4, 23.7 , 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7, 33.9,
            35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8
        };

        private static readonly double[] valoresCriticosGrandes = {
            0, 0, 0, 43.8, 55.8, 67.5, 79.1, 90.5, 101.9, 113.1, 124.3
        };

        public double[] CalcularFila(ConteoFrecuencia conteo, double frecuenciaEsperada, double[] filaAnterior)
        {
            double[] fila = new double[6];

            fila[0] = conteo.Desde;
            fila[1] = conteo.Hasta;
            fila[2] = conteo.Cantidad;
            fila[3] = frecuenciaEsperada;
            fila[4] = Math.Pow(fila[3] - fila[2], 2) / fila[3];
            fila[5] = fila[4];

            if (filaAnterior != null)
                fila[5] += filaAnterior[5];

            return fila;
        }

        public double CalcularValorCritico(int cantidadIntervalos, int tamanioMuestra, int datosEmpiricos)
        {
            int gradosLibertad = cantidadIntervalos - 1 - datosEmpiricos;

            if (gradosLibertad <= 30)
                return valoresCriticos[gradosLibertad - 1];

            gradosLibertad /= 10;

            if (gradosLibertad >= 11)
                return valoresCriticos[11];
            return valoresCriticosGrandes[gradosLibertad];
        }

        public string[] GetColumnasProcedimiento()
        {
            return new string[] { 
                "Desde",
                "Hasta",
                "Frecuencia Observada",
                "Frecuencia Esperada",
                "C",
                "C Acumulado"
            };
        }

        public string GetNombre()
        {
            return "Chi Cuadrado";
        }
    }
}
