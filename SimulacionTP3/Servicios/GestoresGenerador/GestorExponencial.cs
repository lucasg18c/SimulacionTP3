using SimulacionTP3.Modelo;
using SimulacionTP3.Modelo.Distribuciones;
using SimulacionTP3.Presentacion.FormulariosGenerador;
using SimulacionTP3.Presentacion.FormulariosPadre;

namespace SimulacionTP3.Servicios.GestoresGenerador
{
    public class GestorExponencial : GestorGenerador
    {
        private readonly FrmExponencial frmExponencial;
        private double media;
            
        public GestorExponencial(FrmGenerador formulario) : base(formulario)
        {
            frmExponencial = (FrmExponencial)formulario;
        }

        protected override double[] GenerarSerie(Generador generador, int cantidad)
        {
            return generador.GenerarExponencial(media, cantidad);
        }

        protected override Distribucion GetDistribucion()
        {
            return new Exponencial();
        }

        protected override void PedirDatos()
        {
            media = frmExponencial.GetMedia();
        }

        protected override void ValidarDatos()
        {
        }
    }
}
