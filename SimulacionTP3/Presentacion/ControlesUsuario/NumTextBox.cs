using System;
using System.Windows.Forms;

namespace SimulacionTP3.Formularios.ControlesUsuario
{
    public class NumTextBox : TextBox
    {
        public double Valor { get { return CalcularValor(); } }

        public NumTextBox()
        {
            KeyPress += new KeyPressEventHandler(TeclaPresionada);
            AllowDrop = false;
            ShortcutsEnabled = false;
        }

        public void TeclaPresionada(object sender, KeyPressEventArgs evento)
        {
            string filtro = "1234567890";

            if (Text.Length > 0)
                filtro += ".";
            
            foreach (var caracter in filtro)
            {
                if (evento.KeyChar == caracter)
                {
                    evento.Handled = false;
                    break;
                }
                else
                    evento.Handled = true;
            }

            if (char.IsControl(evento.KeyChar))           
                evento.Handled = false;          

            if (evento.KeyChar == '.' && Text.IndexOf('.') > -1)         
                evento.Handled = true; 
        }

        private double CalcularValor()
        {
            if (Text.Length == 0) return 0;
            try
            {
                return Convert.ToDouble(Text);
            }
            catch (Exception)
            {
            }
            return double.NaN;
        }
    }
}
