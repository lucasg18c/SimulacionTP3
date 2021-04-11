using System;
using System.Windows.Forms;

namespace SimulacionTP3.Presentacion
{
    public partial class FrmBase : Form
    {
        private FrmBase anterior;

        public FrmBase()
        {
            InitializeComponent();
        }

        public void Abrir(FrmBase formulario)
        {
            formulario.anterior = this;
            formulario.Show();
            Hide();
        }

        private void FrmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (anterior != null)
                anterior.Show();
        }

        public void MostrarError(string mensaje)
        {
            MessageBox.Show(
                mensaje,
                "Ocurrió un error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        public void MostrarError(Exception error)
        {
            MessageBox.Show(
                error.Message,
                "Ocurrió un error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            Console.Error.WriteLine(error.StackTrace);
        }

        public void MostrarInformacion(string mensaje, string titulo)
        {
            MessageBox.Show(
                mensaje,
                titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
