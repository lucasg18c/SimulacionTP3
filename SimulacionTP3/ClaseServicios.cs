using System;
using System.Windows.Forms;


namespace SimulacionTP3
{
    public class ClaseServicios
    {
        public double[] NumerosAleatorios(double cantidad)
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            double[] vec = new double[Convert.ToInt32(cantidad)];
            for (int i = 1; i <= cantidad; i++)
            {
                var RND = random.NextDouble();
                vec[i - 1] = RND;
            }
            return vec;
        }

        public void DistribucionUniforme(double[] vec, double A, double B, DataGridView datagrid)
        {
            double X;
            for (int i = 1; i <= vec.Length; i++)
            {


                X = A + (vec[i - 1] * (B - A));
                datagrid.Rows.Add(i, (Math.Round(X, 4)));
            }
        }

        public void DistribucionExponencial(double[] vec, double media, double frecuencia, DataGridView datagrid)
        {
            for (int i = 1; i <= vec.Length; i++)
            {

                if (frecuencia == 0)
                {
                    double X = -media * Math.Log(1 - vec[i-1]);
                    datagrid.Rows.Add(i, (Math.Round(X, 4)));
                }
                if (media == 0)
                {
                    double X = (-1 / frecuencia) * Math.Log(1 - vec[i-1]);
                    datagrid.Rows.Add(i, (Math.Round(X, 4)));
                }
            }
        }

        public void MetodoBoxMuller(double cantNum, double media, double desviacion, DataGridView dataGrid)
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            double X;
            for (int i = 1; i <= cantNum; i++)
            {
                var RND1 = random.NextDouble();
                var RND2 = random.NextDouble();
                double N1 = (Math.Sqrt(-2 * (Math.Log(RND1))) * Math.Cos(2 * Math.PI * RND2)) * desviacion + media;
                double N2 = (Math.Sqrt(-2 * (Math.Log(RND1))) * Math.Sin(2 * Math.PI * RND2)) * desviacion + media;

                dataGrid.Rows.Add(i, (Math.Round(RND1, 4)), (Math.Round(RND2, 4)), Math.Round(N1, 4), Math.Round(N2, 4));
            }
        }

        public void MetodoConvolucion(double[] vec, double k, double media, double desviacion, DataGridView dataGrid)
        {
            double RND = 0;
            double Z;
            for (int i = 1; i <= vec.Length; i++)
            {

                for (int i2 = 1; i2 <= k; i2++)
                {
                    RND = RND + vec[i-1];
                }
                Z = (RND - (k / 2)) / (Math.Sqrt(k / 12));
                double X = Z * desviacion + media;
                dataGrid.Rows.Add(Math.Round(X, 4));
                Z = 0;
                X = 0;
                RND = 0;
            }
        }

        public void DistribucionPoisson(double lambda, double cantidad, DataGridView dataGrid)
        {
            double P = 1;
            int X = -1;
            double A = Math.Exp(-lambda);
            var seed = Environment.TickCount;
            var random = new Random(seed);

            for (int i = 1; i <= cantidad; i++)
            {
                do
                {
                    var U = random.NextDouble();
                    P = P * U;
                    X = X + 1;
                } while (P >= A);

                dataGrid.Rows.Add(i, X);
                P = 1;
                X = -1;
                A = Math.Exp(-lambda);

            }
        }

        public void NumerosPosNegDec(TextBox txt, KeyPressEventArgs e)
        {
            string cadena = txt.Text;
            string filtro = "1234567890";

            if (cadena.Length == 0)
            {
                filtro += "-";
            }

            if (cadena.Length > 0)
            {
                filtro += ".";
            }

            foreach (var caracter in filtro)
            {
                if (e.KeyChar == caracter)
                {
                    e.Handled = false;
                    break;
                }
                else
                {
                    e.Handled = true;
                }

            }

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            if (e.KeyChar == '.' && cadena.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        public void NumerosPosDec(TextBox txt, KeyPressEventArgs e)
        {
            string cadena = txt.Text;
            string filtro = "1234567890";

            if (cadena.Length > 0)
            {
                filtro += ".";
            }

            foreach (var caracter in filtro)
            {
                if (e.KeyChar == caracter)
                {
                    e.Handled = false;
                    break;
                }
                else
                {
                    e.Handled = true;
                }

            }

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            if (e.KeyChar == '.' && cadena.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        public void MensajeError()
        {
            MessageBox.Show("ERROR: Datos incorrectos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
