using SimulacionTP3.Modelo;
using SimulacionTP3.Presentacion;

namespace SimulacionTP3.Servicios
{
    public class GestorUniforme : GestorGenerador
    {
        private double a, b;
        private readonly FrmUniforme frmUniforme;
        public GestorUniforme(FrmGenerador formulario) : base(formulario)
        {
            frmUniforme = (FrmUniforme)formulario;
        }

        protected override double[] GenerarSerie(Generador generador)
        {
            return generador.GenerarUniforme(a, b, cantidad);
        }

        protected override void PedirDatos()
        {
            a = frmUniforme.GetA();
            b = frmUniforme.GetB();
        }
    }
}
