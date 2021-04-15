using SimulacionTP3.Modelo.PruebasBondad;

namespace SimulacionTP3.Modelo.Distribuciones
{
    public abstract class Distribucion
    {
        public abstract double[] CalcularFrecuenciasEsperadas(double[] serie, ConteoFrecuencia[] conteos);
        public abstract string GetNombre();
        public abstract int CantidadDatosEmpiricos();

        public virtual bool IntervalosEnteros()
        {
            return false;
        }
        public virtual PruebaBondad ElegirPruebaBondad(int tamanioMuestra)
        {
            if (tamanioMuestra >= 30)
                return new PruebaChiCuadrado();
            
            return new PruebaKS(); 
        }    
    }
}
