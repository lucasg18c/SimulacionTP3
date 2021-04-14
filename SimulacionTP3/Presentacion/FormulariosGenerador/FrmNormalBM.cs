using SimulacionTP3.Presentacion.FormulariosPadre;
using SimulacionTP3.Servicios.GestoresGenerador;

namespace SimulacionTP3.Presentacion.FormulariosGenerador
{
    public partial class FrmNormalBM : FrmGenerador
    {
        public FrmNormalBM()
        {
            InitializeComponent();
            gestor = new GestorNormalBM(this);
        }

        protected override void LimpiarDatos()
        {
            txtMedia.Clear();
            txtDesviacion.Clear();
        }

        public double GetMedia()
        {
            return txtMedia.Valor;
        }

        public double GetDesviacion()
        {
            return txtDesviacion.Valor;
        }
    }
}
