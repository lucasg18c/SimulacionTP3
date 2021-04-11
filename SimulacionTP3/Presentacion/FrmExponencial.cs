using SimulacionTP3.Presentacion.FormulariosPadre;
using SimulacionTP3.Servicios;
using System;

namespace SimulacionTP3.Presentacion
{
    public partial class FrmExponencial : FrmGenerador
    {
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
            txtMedia.Clear();
        }

        private void ModificadoTxtMedia(object sender, EventArgs e)
        {
            txtFrecuencia.Clear();
        }
    }
}
