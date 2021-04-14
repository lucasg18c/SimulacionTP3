using SimulacionTP3.Presentacion.FormulariosPadre;
using SimulacionTP3.Servicios.GestoresGenerador;
using System;

namespace SimulacionTP3.Presentacion.FormulariosGenerador
{
    public partial class FrmExponencial : FrmGenerador
    {
        private bool omitirModificado = false;

        public FrmExponencial()
        {
            InitializeComponent();
            gestor = new GestorExponencial(this);
        }

        protected override void LimpiarDatos()
        {
            txtFrecuencia.Clear();
            txtMedia.Clear(); 
        }

        public double GetFrecuencia()
        {
            return txtFrecuencia.Valor;
        }

        public double GetMedia()
        {
            return txtMedia.Valor;
        }

        private void ModificadoTxtFrecuencia(object sender, EventArgs e)
        {
            if (!omitirModificado)
            {
                omitirModificado = true;
                txtMedia.Clear();
                omitirModificado = false;
            }
            else
                omitirModificado = false;
        }

        private void ModificadoTxtMedia(object sender, EventArgs e)
        {
            if (!omitirModificado)
            {
                omitirModificado = true;
                txtFrecuencia.Clear();
                omitirModificado = false;
            }
            else
                omitirModificado = false;
        }
    }
}
