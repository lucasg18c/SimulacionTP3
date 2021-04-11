using SimulacionTP3.Modelo;
using SimulacionTP3.Presentacion;
using SimulacionTP3.Presentacion.FormulariosPadre;

namespace SimulacionTP3.Servicios
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

        protected override void PedirDatos()
        {
            media = frmNormalBM.GetMedia();
            desviacion = frmNormalBM.GetDesviacion();
        }
    }
}
