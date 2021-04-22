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

        public double GetMedia()
        {
            return media.Valor;
        }

        public double GetDesviacion()
        {
            return desviacion.Valor;
        }

        public void SetDesviacion()
        {
            desviacion.Valor = 1;
        }
    }
}
