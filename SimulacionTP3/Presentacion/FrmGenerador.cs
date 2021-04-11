using SimulacionTP3.Modelo;
using SimulacionTP3.Servicios;
using System;

namespace SimulacionTP3.Presentacion
{
    public partial class FrmGenerador : FrmBase
    {
        protected GestorGenerador gestor;

        protected virtual void LimpiarDatos()
        {
        }

        public FrmGenerador()
        {
            InitializeComponent();
        }

        private void ClickBtnGenerar(object sender, EventArgs e)
        {
            gestor.Generar();
        }


        private void ClickBtnProbar(object sender, EventArgs e)
        {
            gestor.ProbarGenerador(); 
        }

        private void ClickBtnLimpiar(object sender, EventArgs e)
        {
            gestor.Limpiar();
            txtCantidad.Clear();
            txtIntervalos.Clear();
            LimpiarDatos();
        }

        public int GetCantidad()
        {
            return (int) txtCantidad.Valor;
        }

        public int GetIntervalos()
        {
            return (int) txtIntervalos.Valor;
        }

        public void Limpiar()
        {
            grafica.Series["Numeros"].Points.Clear();
            txtSerie.Clear();
        }

        public void MostrarGrafico(ConteoFrecuencia[] conteos)
        {
            foreach (ConteoFrecuencia conteo in conteos)
                grafica.Series["Numeros"].Points.AddXY(conteo.Hasta, conteo.Cantidad);
        }

        public void MostrarSerie(string serie)
        {
            txtSerie.Text = serie;
        }
    }
}
