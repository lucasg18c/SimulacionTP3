using SimulacionTP3.Presentacion;
using System;
using System.Windows.Forms;

namespace SimulacionTP3.Formularios
{
    public partial class FrmNormalConv : FrmBase
    {
        public FrmNormalConv()
        {
            InitializeComponent();
        }

        ClaseServicios servicios = new ClaseServicios();
        private void txtDesviacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblB_Click(object sender, EventArgs e)
        {

        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidadAGenerar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCantidadGenerar_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                double k = double.Parse(txtTamanoMuestra.Text);
                double cantidad = double.Parse(txtCantidadAGenerar.Text);
                double media = double.Parse(txtMedia.Text);
                double desviacion = double.Parse(txtDesviacion.Text);
                tablaNumeros.Rows.Clear();

                servicios.MetodoConvolucion(servicios.NumerosAleatorios(cantidad), k, media, desviacion, tablaNumeros);
            }
            catch (Exception)
            {

                servicios.MensajeError();
            }
            
        }

        private void txtTamanoMuestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            servicios.NumerosPosDec(txtTamanoMuestra, e);
        }

        private void txtMedia_KeyPress(object sender, KeyPressEventArgs e)
        {
            servicios.NumerosPosNegDec(txtMedia, e);
        }

        private void txtDesviacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            servicios.NumerosPosDec(txtDesviacion, e);
        }
    }
}
