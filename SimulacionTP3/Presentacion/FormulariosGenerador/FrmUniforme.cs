using SimulacionTP3.Presentacion.FormulariosPadre;
using SimulacionTP3.Servicios.GestoresGenerador;

namespace SimulacionTP3.Presentacion.FormulariosGenerador
{
    public partial class FrmUniforme : FrmGenerador
    {
        public FrmUniforme()
        {
            InitializeComponent();
            gestor = new GestorUniforme(this);
        }

        public double GetA()
        {
            return desde.Valor;
        }

        public double GetB()
        {
            return hasta.Valor;
        }
    }
}
