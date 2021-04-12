namespace SimulacionTP3.Modelo.PruebasBondad
{
    public interface IPruebaBondad
    {
        double[] CalcularFila(ConteoFrecuencia conteo, double frecuenciaEsperada, double[] filaAnterior);
        string[] GetColumnasProcedimiento();
        double CalcularValorCritico(int cantidadIntervalos, int tamanioMuestra, int datosEmpiricos);
        string GetNombre();
    }
}
