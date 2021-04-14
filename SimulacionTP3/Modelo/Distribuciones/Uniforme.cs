using SimulacionTP3.Modelo.PruebasBondad;

namespace SimulacionTP3.Modelo.Distribuciones
{
    public class Uniforme : IDistribucion
    {
        public double[] CalcularFrecuenciasEsperadas(double[] serie, ConteoFrecuencia[] conteos)
        {
            int k, n;
            double fe;
            double[] frecuencias;

            k = conteos.Length;
            n = serie.Length;
            frecuencias = new double[k];
            fe = (double)n / k;

            for (int i = 0; i < k; i++)
                frecuencias[i] = fe;                

            return frecuencias;
        }

        public int GetDatosEmpiricos()
        {
            return 0;
        }

        public string GetNombre()
        {
            return "Uniforme";
        }
        public IPruebaBondad ElegirPruebaBondad(int tamanioMuestra)
        {
            if (tamanioMuestra >= 30)
                return new PruebaChiCuadrado();
            else
                return new PruebaKS();
        }
    }
}
