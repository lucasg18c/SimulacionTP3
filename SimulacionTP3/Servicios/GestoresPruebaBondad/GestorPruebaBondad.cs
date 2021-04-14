using SimulacionTP3.Modelo;
using SimulacionTP3.Modelo.Distribuciones;
using SimulacionTP3.Modelo.PruebasBondad;
using SimulacionTP3.Presentacion.FormulariosVarios;
using System;
using System.Collections.Generic;

namespace SimulacionTP3.Servicios.GestoresPruebaBondad
{
    public class GestorPruebaBondad
    {
        private ConteoFrecuencia[] conteos;
        private double[] serie, frecuenciasEsperadas;
        private double[][] procedimiento;
        private string[][] tablaProcedimiento;
        private double valorCritico, estadisticoPrueba;
        private IPruebaBondad pruebaBondad;
        private IDistribucion distribucion;

        private static readonly int DECIMALES_REDONDEO = 4;

        public void SetDistribucion(IDistribucion distribucion)
        {
            this.distribucion = distribucion;
        }

        public void CalcularPrueba(double[] serie, ConteoFrecuencia[] conteos)
        {
            this.serie = serie;
            this.conteos = conteos;
            ElegirPruebaBondad();
            frecuenciasEsperadas = distribucion.CalcularFrecuenciasEsperadas(serie, conteos);
            AgruparFrecuenciasEsperadas();
            CalcularProcedimiento();
            PrepararProcedimiento();
            valorCritico = pruebaBondad.CalcularValorCritico(conteos.Length, serie.Length, distribucion.GetDatosEmpiricos());
            MostrarSolucion();
        }

        private void AgruparFrecuenciasEsperadas()
        {
            if (!pruebaBondad.AgruparFrecuenciasEsperadas()) 
                return;

            List<ConteoFrecuencia> tempFO = new List<ConteoFrecuencia>();
            List<double> tempFE = new List<double>();
            int sumaFO, desdePos = 0;
            double fe, sumaRestante, sumaFE = 0;
            bool alcanza;

            for (int i = 0; i < conteos.Length; i++)
            {
                fe = frecuenciasEsperadas[i] + sumaFE;
                
                if (fe >= 5)
                {
                    if (i < conteos.Length - 1)
                    {
                        sumaRestante = 0;
                        alcanza = false;

                        for (int j = i + 1; j < conteos.Length; j++)
                        {
                            sumaRestante += frecuenciasEsperadas[j];

                            if (sumaRestante >= 5)
                            {
                                alcanza = true;
                                break;
                            }
                        }

                        if (alcanza)
                        {
                            if (desdePos == -1)
                            {
                                sumaFO = conteos[i].Cantidad;
                                desdePos = i;
                            }
                                
                            else
                            {
                                sumaFO = 0;
                                for (int k = desdePos; k <= i; k++)
                                    sumaFO += conteos[k].Cantidad;
                            }

                            tempFO.Add(new ConteoFrecuencia
                            {
                                Desde = conteos[desdePos].Desde,
                                Hasta = conteos[i].Hasta,
                                Cantidad = sumaFO
                            });
                            tempFE.Add(fe);
                            sumaFE = 0;
                            desdePos = -1;
                            
                        }
                        else
                        {
                            if (desdePos == -1)
                                desdePos = i;
                            sumaFO = 0;
                            for (int k = desdePos; k < conteos.Length; k++)
                                sumaFO += conteos[k].Cantidad;

                            tempFO.Add(new ConteoFrecuencia
                            {
                                Desde = conteos[desdePos].Desde,
                                Hasta = conteos[conteos.Length - 1].Hasta,
                                Cantidad = sumaFO
                            });

                            tempFE.Add(fe + sumaRestante);
                            break;
                        }
                    }
                }
                else
                {
                    if (desdePos == -1)
                        desdePos = i;
                    sumaFE = fe;
                }
            }
            frecuenciasEsperadas = tempFE.ToArray();
            conteos = tempFO.ToArray();
        }

        private void ElegirPruebaBondad()
        {
            pruebaBondad = distribucion.ElegirPruebaBondad(TamanioMuestra());
        }

        private int TamanioMuestra()
        {
            return serie.Length;
        }

        private void MostrarSolucion()
        {
            FrmPruebaBondad form = new FrmPruebaBondad();
            form.SetColumnasProcedimiento(pruebaBondad.GetColumnasProcedimiento());
            form.MostrarProcedimiento(tablaProcedimiento);
            form.MostrarEstadisticoPrueba(Math.Round(estadisticoPrueba, 4).ToString());
            form.MostrarValorCritico(Math.Round(valorCritico, 4).ToString());
            form.MostrarNombrePrueba(pruebaBondad.GetNombre());
            form.MostrarConclusion(GetConclusion());
            form.ShowDialog();
        }

        private string GetConclusion()
        {
            if (estadisticoPrueba <= valorCritico)
                return $"No se puede rechazar la hipotesis nula, la distribución es {distribucion.GetNombre()}.";

            return $"Se ha rechazado la hipotesis nula, por lo tanto la distribución no es {distribucion.GetNombre()}.";
        }

        private void PrepararProcedimiento()
        {
            int filas, columnas;

            filas = procedimiento.Length;
            columnas = procedimiento[0].Length;
            tablaProcedimiento = new string[filas][];

            for (int i = 0; i < filas; i++)
            {
                string[] fila = new string[columnas];
                
                for (int j = 0; j < columnas; j++)
                    fila[j] = Math.Round(procedimiento[i][j], DECIMALES_REDONDEO).ToString();

                tablaProcedimiento[i] = fila;
            }
        }

        private void CalcularProcedimiento()
        {
            int n = conteos.Length;
            procedimiento = new double[n][];
            procedimiento[0] = pruebaBondad.CalcularFila(conteos[0], frecuenciasEsperadas[0], null, serie.Length);

            for (int i = 1; i < n; i++)
                procedimiento[i] = pruebaBondad.CalcularFila(conteos[i], frecuenciasEsperadas[i], procedimiento[i - 1], serie.Length);

            estadisticoPrueba = procedimiento[n - 1][procedimiento[0].Length - 1];
        }
    }
}
