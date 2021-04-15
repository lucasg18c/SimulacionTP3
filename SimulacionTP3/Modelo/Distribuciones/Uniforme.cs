namespace SimulacionTP3.Modelo.Distribuciones
{
    public class Uniforme : Distribucion
    {
        public override double[] CalcularFrecuenciasEsperadas(double[] serie, ConteoFrecuencia[] conteos)
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

        public override int CantidadDatosEmpiricos()
        {
            return 0;
        }

        public override string GetNombre()
        {
            return "Uniforme";
        }
    }
}
