using SimulacionTP3.Presentacion.FormulariosPadre;
using SimulacionTP3.Servicios.GestoresGenerador;

namespace SimulacionTP3.Presentacion.FormulariosGenerador
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
            txtMedia.Clear(); 
        }

        public double GetMedia()
        {
            return txtMedia.Valor;
        }
    }
}
