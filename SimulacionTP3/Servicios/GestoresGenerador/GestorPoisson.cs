using SimulacionTP3.Modelo;
using SimulacionTP3.Modelo.Distribuciones;
using SimulacionTP3.Presentacion.FormulariosGenerador;
using SimulacionTP3.Presentacion.FormulariosPadre;

namespace SimulacionTP3.Servicios.GestoresGenerador
{
    public class GestorPoisson : GestorGenerador
    {
        private double frecuencia;
        private readonly FrmPoisson frmPoisson;

        public GestorPoisson(FrmGenerador formulario) : base(formulario)
        {
            frmPoisson = (FrmPoisson)formulario;
        }

        protected override double[] GenerarSerie(Generador generador, int cantidad)
        {
            return generador.GenerarPoisson(frecuencia, cantidad);
        }

        protected override void PedirDatos()
        {
            frecuencia = frmPoisson.GetFrecuencia();
        }

        protected override IDistribucion GetDistribucion()
        {
            return new Poisson();
        }

        protected override void ValidarDatos()
        {
            
        }
    }
}
