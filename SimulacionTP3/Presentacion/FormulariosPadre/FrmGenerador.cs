using SimulacionTP3.Servicios.GestoresGenerador;
using System;
using System.Windows.Forms;

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

        private void ClickBtnExportar(object sender, EventArgs e)
        {
            gestor.Exportar();
        }

        public int GetCantidad()
        {
            return (int) cantidad.Valor;
        }

        public int GetIntervalos()
        {
            return (int) intervalos.Valor;
        }

        public void MostrarGrafico(double x, double y)
        {
            grafica.Series["Numeros"].Points.AddXY(x, y);
        }

        public void MostrarSerie(string serie)
        {
            txtSerieAleatoria.Text = serie;
        }

        public void Esperar(bool esperar)
        {
            if (esperar)
                Cursor.Current = Cursors.WaitCursor;
            else
                Cursor.Current = Cursors.Default;
        }

        public void HabilitarPrueba(bool habilitar)
        {
            btnProbar.Visible = habilitar;
            btnExportar.Visible = habilitar;
        }

        public void Limpiar()
        {
            grafica.Series["Numeros"].Points.Clear();
        }

        public void SetPortapapeles(string texto)
        {
            Clipboard.SetText(texto);
        }

        private void ClickBtnNombreApp(object sender, EventArgs e)
        {
            Close();
        }
    }
}
