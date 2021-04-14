using SimulacionTP3.Presentacion.FormulariosPadre;
using SimulacionTP3.Servicios.GestoresGenerador;

namespace SimulacionTP3.Presentacion.FormulariosGenerador
{
    public partial class FrmNormalConvolucion : FrmGenerador
    {
        public FrmNormalConvolucion()
        {
            InitializeComponent();
            gestor = new GestorConvolucion(this);
        }

        protected override void LimpiarDatos()
        {
            txtDesviacion.Clear();
            txtMedia.Clear();
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
