using SimulacionTP3.Presentacion.FormulariosPadre;
using SimulacionTP3.Servicios.GestoresGenerador;

namespace SimulacionTP3.Presentacion.FormulariosGenerador
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
