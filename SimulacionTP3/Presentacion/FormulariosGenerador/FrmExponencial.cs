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

        public double GetMedia()
        {
            return media.Valor;
        }
    }
}
