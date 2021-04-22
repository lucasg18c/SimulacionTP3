using SimulacionTP3.Modelo;
using SimulacionTP3.Modelo.Distribuciones;
using SimulacionTP3.Presentacion.FormulariosGenerador;
using SimulacionTP3.Presentacion.FormulariosPadre;


namespace SimulacionTP3.Servicios.GestoresGenerador
{
    public class GestorNormalBM : GestorGenerador
    {
        private readonly FrmNormalBM frmNormalBM;
        private double media, desviacion;

        public GestorNormalBM(FrmGenerador formulario) : base(formulario)
        {
            frmNormalBM = (FrmNormalBM)formulario;
        }

        protected override double[] GenerarSerie(Generador generador, int cantidad)
        {
            return generador.GenerarNormalBM(media, desviacion, cantidad);
        }

        protected override Distribucion GetDistribucion()
        {
            return new Normal();
        }

        protected override void PedirDatos()
        {
            media = frmNormalBM.GetMedia();
            desviacion = frmNormalBM.GetDesviacion();
            if (desviacion == 0)
            {
                frmNormalBM.MostrarError("No puede introducirse el valor cero como desviacion estandar, Se cambio al numero 1 " +
                    "por defecto. Puede ingresar nuevamente la misma si asi lo desea.");
                desviacion = 1;
                frmNormalBM.SetDesviacion();
            }
            
        }

        protected override void ValidarDatos()
        {
           
        }
    }
}
