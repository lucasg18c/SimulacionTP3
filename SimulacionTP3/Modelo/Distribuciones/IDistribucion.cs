using SimulacionTP3.Modelo.PruebasBondad;

namespace SimulacionTP3.Modelo.Distribuciones
{
    public interface IDistribucion
    {
        double[] CalcularFrecuenciasEsperadas(double[] serie, ConteoFrecuencia[] conteos);
        string GetNombre();
        int GetDatosEmpiricos();
        IPruebaBondad ElegirPruebaBondad(int tamanioMuestra);
    }
}
