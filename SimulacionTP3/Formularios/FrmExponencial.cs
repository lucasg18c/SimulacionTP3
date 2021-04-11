using SimulacionTP3.Presentacion;
using SimulacionTP3.Servicios;
using System;

namespace SimulacionTP3.Formularios
{
    public partial class FrmExponencial : FrmBase
    {
        private readonly GestorExponencial gestor;

        public FrmExponencial()
        {
            InitializeComponent();
            gestor = new GestorExponencial(this);
        }

        private void ClickBtnGenerar(object sender, EventArgs e)
        {
            gestor.Generar();
        }

        private void ModificadoTxtFrecuencia(object sender, EventArgs e)
        {
            txtMedia.Enabled = false;
            if (txtFrecuencia.TextLength == 0)
                txtMedia.Enabled = true;
        }

        public double GetCantidad()
        {
            return txtCantidadAGenerar.Valor;
        }

        public void LimpiarTabla()
        {
            tablaNumeros.Rows.Clear();
        }

        public double GetFrecuencia()
        {
            return txtFrecuencia.Valor;
        }

        public double GetMedia()
        {
            return txtMedia.Valor;
        }

        public void MostrarTabla(string[] numeros)
        {
            LimpiarTabla();

            for (int i = 0; i < numeros.Length; i++)

                tablaNumeros.Rows.Add(new string[]
                {
                    (i+1).ToString(),
                    numeros[i]
                });
        }

        private void ModificadoTxtMedia(object sender, EventArgs e)
        {
            txtFrecuencia.Enabled = false;
            if (txtMedia.TextLength == 0)
                txtFrecuencia.Enabled = true;
        }
    }
}
