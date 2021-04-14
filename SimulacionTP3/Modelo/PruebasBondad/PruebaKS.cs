﻿using System;

namespace SimulacionTP3.Modelo.PruebasBondad
{
    public class PruebaKS : IPruebaBondad
    {
        private static readonly double[] valCriticos = {
            0.9750, 0.8418, 0.7076, 0.6239, 0.5632, 0.5192, 0.4834, 0.4542, 0.4300,
            0.4092, 0.3912, 0.3754, 0.3614, 0.3489 , 0.3375, 0.3273, 0.3179, 0.3093,
            0.3014, 0.2940, 0.2872, 0.2808, 0.2749, 0.2693, 0.2640, 0.2590, 0.2543,
            0.2499, 0.2457, 0.2417, 0.2378, 0.2342, 0.2307, 0.2274, 0.2242
        };

        public bool AgruparFrecuenciasEsperadas()
        {
            return false;
        }

        public double[] CalcularFila(ConteoFrecuencia conteo, double frecuenciaEsperada, double[] filaAnterior, int tamanioMuestra)
        {
            double[] fila = new double[10];

            fila[0] = conteo.Desde;
            fila[1] = conteo.Hasta;
            fila[2] = conteo.Cantidad;
            fila[3] = frecuenciaEsperada;
            fila[4] = fila[2] / tamanioMuestra;
            fila[5] = frecuenciaEsperada / tamanioMuestra;
            fila[6] = fila[4];
            fila[7] = fila[5];

            if (filaAnterior != null)
            {
                fila[6] += filaAnterior[6];
                fila[7] += filaAnterior[7];
            }

            fila[8] = Math.Abs(fila[6] - fila[7]);
            fila[9] = fila[8];

            if (filaAnterior != null && fila[9] < filaAnterior[9])
                fila[9] = filaAnterior[9];
            
            return fila;
        }

        public double CalcularValorCritico(int cantidadIntervalos, int tamanioMuestra, int datosEmpiricos)
        {
            if (tamanioMuestra > 35)
                return Math.Round(1.36 / Math.Sqrt(tamanioMuestra), 4);

            return valCriticos[tamanioMuestra - 1];
        }

        public string[] GetColumnasProcedimiento()
        {
            return new string[] { 
                "Desde",
                "Hasta",
                "F. Observada",
                "F. Esperada",
                "P. Observada",
                "P. Esperada",
                "P.O. Acumulada",
                "P.E. Acumulada",
                "|POAc - PEAc|",
                "max |POAc - PEAc|"
            };
        }

        public string GetNombre()
        {
            return "Kolmogorov - Smirnov";
        }
    }
}
