using SimulacionTP3.Presentacion;
using System;
using System.Windows.Forms;

namespace SimulacionTP3.Formularios
{
    public partial class FrmPoisson : FrmBase
    {
        public FrmPoisson()
        {
            InitializeComponent();
        }

        ClaseServicios servicios = new ClaseServicios();
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                double lambda = double.Parse(txtFrecuencia.Text);
                double cantidad = double.Parse(txtCantidadAGenerar.Text);
                tablaNumeros.Rows.Clear();

                servicios.DistribucionPoisson(lambda, cantidad, tablaNumeros);
            }
            catch (Exception)
            {

                servicios.MensajeError();
            }

        }

        private void txtFrecuencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            servicios.NumerosPosDec(txtFrecuencia, e);
        }
    }
}
