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
            rb5.Checked = false;
            rb10.Checked = true;
            rb15.Checked = false;
            rb20.Checked = false;
            LimpiarDatos();
        }

        public int GetCantidad()
        {
            return (int) txtCantidad.Valor;
        }

        public int GetIntervalos()
        {
            if (rb5.Checked) return 5; 
            if (rb10.Checked) return 10; 
            if (rb15.Checked) return 15; 
            else return 20; 
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
