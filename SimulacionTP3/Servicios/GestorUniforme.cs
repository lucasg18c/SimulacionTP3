using SimulacionTP3.Modelo;
using SimulacionTP3.Modelo.Distribuciones;
using SimulacionTP3.Presentacion;
using SimulacionTP3.Presentacion.FormulariosPadre;

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

        protected override double[] GenerarSerie(Generador generador, int cantidad)
        {
            return generador.GenerarUniforme(a, b, cantidad);
        }

        protected override void PedirDatos()
        {
            a = frmUniforme.GetA();
            b = frmUniforme.GetB();
        }

        protected override IDistribucion GetDistribucion()
        {
            return new Uniforme();
        }
    }
}
