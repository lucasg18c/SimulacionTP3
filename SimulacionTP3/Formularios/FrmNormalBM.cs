using SimulacionTP3.Presentacion;
using System;
using System.Windows.Forms;

namespace SimulacionTP3.Formularios
{
    public partial class FrmNormalBM : FrmBase
    {
        public FrmNormalBM()
        {
            InitializeComponent();
        }

        ClaseServicios servicios = new ClaseServicios();
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidadGenerar = double.Parse(txtCantidadAGenerar.Text);
                double media = double.Parse(txtMedia.Text);
                double desviacion = double.Parse(txtDesviacion.Text);
                tablaNumeros.Rows.Clear();

                servicios.MetodoBoxMuller(cantidadGenerar, media, desviacion, tablaNumeros);
            }
            catch (Exception)
            {

                servicios.MensajeError();
            }
            
        }

        private void txtDesviacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            servicios.NumerosPosDec(txtDesviacion, e);
        }

        private void txtMedia_KeyPress(object sender, KeyPressEventArgs e)
        {
            servicios.NumerosPosNegDec(txtMedia, e);
        }
    }
}
