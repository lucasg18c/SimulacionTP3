using SimulacionTP3.Modelo;
using SimulacionTP3.Modelo.Distribuciones;
using SimulacionTP3.Presentacion;
using SimulacionTP3.Presentacion.FormulariosPadre;

namespace SimulacionTP3.Servicios
{
    public class GestorExponencial : GestorGenerador
    {
        private readonly FrmExponencial frmExponencial;
        private double frecuencia, media;
            
        public GestorExponencial(FrmGenerador formulario) : base(formulario)
        {
            frmExponencial = (FrmExponencial)formulario;
        }

        protected override double[] GenerarSerie(Generador generador, int cantidad)
        {
            return generador.GenerarExponencial(media, frecuencia, cantidad);
        }

        protected override IDistribucion GetDistribucion()
        {
            return new Exponencial();
        }

        protected override void PedirDatos()
        {
            frecuencia = frmExponencial.GetFrecuencia();
            media = frmExponencial.GetMedia();
        }
    }
}
