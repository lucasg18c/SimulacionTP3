using System;

namespace SimulacionTP3.Modelo.Generadores
{
    public class GeneradorExponencial : GeneradorBase
    {
        public override double[] Generar(int cantidad, double media, double frecuencia)
        {
            double[] serie, uniforme;
            double a;

            serie = new double[cantidad];
            uniforme = GenerarUniforme(cantidad);

            if (frecuencia == 0) a = -media;
            else a = -1 / frecuencia;

            if (frecuencia == 0)
                for (int i = 0; i < cantidad; i++)
                    serie[i] = a * Math.Log(1 - uniforme[i]);

            return serie;
        }
    }
}
