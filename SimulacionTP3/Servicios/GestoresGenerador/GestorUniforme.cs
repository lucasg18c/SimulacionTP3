using SimulacionTP3.Modelo;
using SimulacionTP3.Modelo.Distribuciones;
using SimulacionTP3.Presentacion.FormulariosGenerador;
using SimulacionTP3.Presentacion.FormulariosPadre;
using System;

namespace SimulacionTP3.Servicios.GestoresGenerador
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

        protected override void ValidarDatos()
        {
            if (a >= b)
                throw new ApplicationException("A debe ser menor que B.");
        }
    }
}
