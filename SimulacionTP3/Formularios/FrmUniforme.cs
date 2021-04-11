using SimulacionTP3.Presentacion;
using System;
using System.Windows.Forms;


namespace SimulacionTP3.Formularios
{
    public partial class FrmUniforme : FrmBase
    {
        public FrmUniforme()
        {
            InitializeComponent();
        }

        ClaseServicios servicios = new ClaseServicios();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                double A = double.Parse(txtA.Text);
                double B = double.Parse(txtB.Text);
                double cantidadGenerar = double.Parse(txtCantidadAGenerar.Text);
                tablaNumeros.Rows.Clear();

                if (B_MayorQue_A(B, A))
                {
                    double[] vectorNumAleatorios = servicios.NumerosAleatorios(cantidadGenerar);
                    servicios.DistribucionUniforme(vectorNumAleatorios, A, B, tablaNumeros);
                }
                else
                {
                    servicios.MensajeError();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Datos incorrectos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool B_MayorQue_A(double b, double a)
        {
            if (b > a)
            {
                return true;
            }
            else
                return false;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            servicios.NumerosPosNegDec(txtA, e);
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            servicios.NumerosPosNegDec(txtB, e);
        }
    }
}
