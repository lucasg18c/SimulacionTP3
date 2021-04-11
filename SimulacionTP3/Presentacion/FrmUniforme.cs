using SimulacionTP3.Presentacion.FormulariosPadre;
using SimulacionTP3.Servicios;
using System;

namespace SimulacionTP3.Presentacion
{
    public partial class FrmUniforme : FrmGenerador
    {
        public FrmUniforme()
        {
            InitializeComponent();
            gestor = new GestorUniforme(this);
        }

        protected override void LimpiarDatos()
        {
            txtA.Clear();
            txtB.Clear();
        }

        public double GetA()
        {
            return txtA.Valor;
        }

        public double GetB()
        {
            return txtB.Valor;
        }
    }
}
