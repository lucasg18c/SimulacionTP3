namespace SimulacionTP3.Modelo
{
    public class ConteoFrecuencia
    {
        public double Desde { get; set; }
        public double Hasta { get; set; }
        public double Cantidad { get; set; }

        public void Contar()
        {
            Cantidad++;
        }
    }
}
