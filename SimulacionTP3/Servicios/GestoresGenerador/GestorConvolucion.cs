using SimulacionTP3.Modelo;
using SimulacionTP3.Modelo.Distribuciones;
using SimulacionTP3.Presentacion.FormulariosGenerador;
using SimulacionTP3.Presentacion.FormulariosPadre;

namespace SimulacionTP3.Servicios.GestoresGenerador
{
    public class GestorConvolucion : GestorGenerador
    {
        private double media, desviacion;
        private readonly FrmNormalConvolucion frmConvolucion;

        public GestorConvolucion(FrmGenerador formulario) : base(formulario)
        {
            frmConvolucion = (FrmNormalConvolucion)formulario;
        }

        protected override double[] GenerarSerie(Generador generador, int cantidad)
        {
            return generador.GenerarNormalConvolucion(media, desviacion, cantidad);
        }

        protected override void PedirDatos()
        {
            media = frmConvolucion.GetMedia();
            desviacion = frmConvolucion.GetDesviacion();
        }

        protected override Distribucion GetDistribucion()
        {
            return new Normal();
        }

        protected override void ValidarDatos()
        {
        }
    }
}
