using SimulacionTP3.Servicios.GestoresGenerador;
using System;

namespace SimulacionTP3.Presentacion.FormulariosPadre
{
    public partial class FrmGenerador : FrmBase
    {
        protected GestorGenerador gestor;

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

        public void MostrarGrafico(double x, double y)
        {
            grafica.Series["Numeros"].Points.AddXY(x, y);
        }

        public void MostrarSerie(string serie)
        {
            txtSerie.Text = serie;
        }

        protected virtual void LimpiarDatos()
        {
        }

        public void HabilitarPrueba(bool habilitar)
        {
            btnProbar.Enabled = habilitar;
        }
    }
}
