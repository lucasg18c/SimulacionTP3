using SimulacionTP3.Modelo;
using SimulacionTP3.Modelo.Distribuciones;
using SimulacionTP3.Presentacion.FormulariosGenerador;
using SimulacionTP3.Presentacion.FormulariosPadre;

namespace SimulacionTP3.Servicios.GestoresGenerador
{
    public class GestorPoisson : GestorGenerador
    {
        private double media;
        private readonly FrmPoisson frmPoisson;

        public GestorPoisson(FrmGenerador formulario) : base(formulario)
        {
            frmPoisson = (FrmPoisson)formulario;
        }

        protected override double[] GenerarSerie(Generador generador, int cantidad)
        {
            return generador.GenerarPoisson(media, cantidad);
        }

        protected override void PedirDatos()
        {
            media = frmPoisson.GetMedia();
        }

        protected override Distribucion GetDistribucion()
        {
            return new Poisson();
        }

        protected override void ValidarDatos()
        {
            
        }
    }
}
