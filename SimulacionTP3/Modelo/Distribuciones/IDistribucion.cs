namespace SimulacionTP3.Modelo.Distribuciones
{
    public interface IDistribucion
    {
        double[] CalcularFrecuenciasEsperadas(double[] serie, ConteoFrecuencia[] conteos);
        string GetNombre();
        int GetDatosEmpiricos();
    }
}
