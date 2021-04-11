using SimulacionTP3.Presentacion.FormulariosPadre;
using System;

namespace SimulacionTP3.Presentacion
{
    public partial class FrmMenuPrincipal : FrmBase
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ClickBtnPoisson(object sender, EventArgs e)
        {
            SubMenu.Visible = false;
            Abrir(new FrmPoisson());
        }

        private void ClickBtnNormalBM(object sender, EventArgs e)
        {
            Abrir(new FrmNormalBM());
        }

        private void ClickBtnNormal(object sender, EventArgs e)
        {
            SubMenu.Visible = !SubMenu.Visible;
        }

        private void ClickBtnUniforme(object sender, EventArgs e)
        {
            SubMenu.Visible = false;
            Abrir(new FrmUniforme());
        }

        private void ClickBtnExponencial(object sender, EventArgs e)
        {
            SubMenu.Visible = false;
            Abrir(new FrmExponencial());
        }

        private void ClickBtnConvolucion(object sender, EventArgs e)
        {
            SubMenu.Visible = false;
            Abrir(new FrmNormalConvolucion());
        }
    }
}
