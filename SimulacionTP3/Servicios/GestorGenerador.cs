﻿using SimulacionTP3.Modelo;
using SimulacionTP3.Presentacion;
using System;

namespace SimulacionTP3.Servicios
{
    public abstract class GestorGenerador
    {
        protected readonly FrmGenerador formulario;
        private readonly Generador generador;
        private double[] serie;
        private ConteoFrecuencia[] conteo;
        protected int intervalos, cantidad;

        protected abstract double[] GenerarSerie(Generador generador);
        protected abstract void PedirDatos();

        public GestorGenerador(FrmGenerador formulario)
        {
            this.formulario = formulario;
            generador = new Generador();
        }

        public void Generar()
        {
            try
            {
                intervalos = formulario.GetIntervalos();
                cantidad = formulario.GetCantidad();
                PedirDatos();
                serie = GenerarSerie(generador);
                ConteoFrecuencias();
                
                formulario.Limpiar();
                formulario.MostrarGrafico(conteo);
                formulario.MostrarSerie(MostrarSerie());
            }
            catch(Exception ex)
            {
                formulario.MostrarError(ex);
            }
        }

        private string MostrarSerie()
        {
            string serieStr = "";
            for (int i = 0; i < cantidad; i++)
            {
                serieStr += Math.Round(serie[i], 4).ToString();
                if (i < cantidad - 1)
                    serieStr += " - ";
            }

            return serieStr;
        }

        private void ConteoFrecuencias()
        {
            int posicion;
            double anchoIntervalo, mayor, menor, inicioIntervalo;

            if (intervalos == 0)
                intervalos = (int) Math.Sqrt(cantidad);

            mayor = menor = serie[0];

            foreach (double d in serie)
            {
                if (d < menor) menor = d;
                if (d > mayor) mayor = d;
            }
            menor = Math.Truncate(menor);
            mayor = Math.Ceiling(mayor);

            anchoIntervalo = (mayor - menor) / intervalos;

            if (anchoIntervalo * intervalos < menor)
            {
                menor = (menor + anchoIntervalo * intervalos) / 2;
                anchoIntervalo = (mayor - menor) / intervalos;
            }

            conteo = new ConteoFrecuencia[intervalos];

            for (int i = 0; i < intervalos; i++)
            {
                inicioIntervalo = menor + i * anchoIntervalo;

                conteo[i] = new ConteoFrecuencia
                {
                    Desde = inicioIntervalo,
                    Hasta = inicioIntervalo + anchoIntervalo,
                    Cantidad = 0
                };
            }

            foreach (double d in serie)
            {
                posicion = (int)(d / anchoIntervalo);
                //Console.WriteLine($"min: {menor} may: {mayor} d: {d}  ancho: {anchoIntervalo}  cantida intervalos: {intervalos}  pos: {posicion}");
                if (posicion >= intervalos)
                    posicion -= intervalos;
                conteo[posicion].Contar();
            }
        }

        public void Limpiar()
        {
            formulario.Limpiar();
        }

        public void ProbarGenerador()
        {

        }
    }
}