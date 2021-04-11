using SimulacionTP3.Presentacion.FormulariosPadre;
using SimulacionTP3.Servicios;

namespace SimulacionTP3.Presentacion
{
    public partial class FrmPoisson : FrmGenerador
    {
        public FrmPoisson()
        {
            InitializeComponent();
            gestor = new GestorPoisson(this);
        }

        public double GetFrecuencia()
        {
            return txtFrecuencia.Valor;
        }

        protected override void LimpiarDatos()
        {
            txtFrecuencia.Clear();
        }
    }
}
