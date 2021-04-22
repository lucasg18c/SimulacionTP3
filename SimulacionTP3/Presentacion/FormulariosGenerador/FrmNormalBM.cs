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

        private void pnlDatos_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
