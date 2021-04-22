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
            if (desviacion == 0)
            {
                frmConvolucion.MostrarError("No puede introducirse el valor cero como desviacion estandar, Se cambio al numero 1 " +
                    "por defecto. Puede ingresar nuevamente la misma si asi lo desea.");
                desviacion = 1;
                frmConvolucion.SetDesviacion();
            }


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
