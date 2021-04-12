using SimulacionTP3.Modelo;
using SimulacionTP3.Modelo.Distribuciones;
using SimulacionTP3.Modelo.PruebasBondad;
using SimulacionTP3.Presentacion;
using System;

namespace SimulacionTP3.Servicios
{
    public class GestorPruebaBondad
    {
        private ConteoFrecuencia[] conteos;
        private double[] serie, frecuenciasEsperadas;
        private double[][] procedimiento;
        private string[][] tablaProcedimiento;
        private string conclusion;
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
            CalcularProcedimiento();
            PrepararProcedimiento();
            valorCritico = pruebaBondad.CalcularValorCritico(conteos.Length, serie.Length, distribucion.GetDatosEmpiricos());
            CalcularConclusion();
            MostrarSolucion();
        }

        private void ElegirPruebaBondad()
        {
            if (TamanioMuestra() >= 30)
                pruebaBondad = new PruebaChiCuadrado();
            else
                pruebaBondad = new PruebaKS();
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
            form.MostrarConclusion(conclusion);
            form.ShowDialog();
        }

        private void CalcularConclusion()
        {
            conclusion = $"ESTADÍSTICO DE PRUEBA: {estadisticoPrueba}\nVALOR CRÍTICO: {valorCritico}\n" +
                $"PRUEBA DE BONDAD UTILIZADA: {pruebaBondad.GetNombre()}\n";

            if (estadisticoPrueba <= valorCritico)
                conclusion += $"No se puede rechazar la hipotesis nula, la distribución es {distribucion.GetNombre()}.";
            
            else
                conclusion = $"Se ha rechazado la hipotesis nula, por lo tanto la distribución no es {distribucion.GetNombre()}.";
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
            procedimiento[0] = pruebaBondad.CalcularFila(conteos[0], frecuenciasEsperadas[0], null);

            for (int i = 1; i < n; i++)
                procedimiento[i] = pruebaBondad.CalcularFila(conteos[i], frecuenciasEsperadas[i], procedimiento[i - 1]);

            estadisticoPrueba = procedimiento[n - 1][procedimiento[0].Length - 1];
        }
    }
}
