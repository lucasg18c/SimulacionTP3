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

        //public void NumerosPosNegDec(TextBox txt, KeyPressEventArgs e)
        //{
        //    string cadena = txt.Text;
        //    string filtro = "1234567890";

        //    if (cadena.Length == 0)
        //    {
        //        filtro += "-";
        //    }

        //    if (cadena.Length > 0)
        //    {
        //        filtro += ".";
        //    }

        //    foreach (var caracter in filtro)
        //    {
        //        if (e.KeyChar == caracter)
        //        {
        //            e.Handled = false;
        //            break;
        //        }
        //        else
        //        {
        //            e.Handled = true;
        //        }

        //    }

        //    if (char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = false;
        //    }

        //    if (e.KeyChar == '.' && cadena.IndexOf('.') > -1)
        //    {
        //        e.Handled = true;
        //    }
        //}

        //public void NumerosPosDec(TextBox txt, KeyPressEventArgs e)
        //{
        //    string cadena = txt.Text;
        //    string filtro = "1234567890";

        //    if (cadena.Length > 0)
        //    {
        //        filtro += ".";
        //    }

        //    foreach (var caracter in filtro)
        //    {
        //        if (e.KeyChar == caracter)
        //        {
        //            e.Handled = false;
        //            break;
        //        }
        //        else
        //        {
        //            e.Handled = true;
        //        }

        //    }

        //    if (char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = false;
        //    }

        //    if (e.KeyChar == '.' && cadena.IndexOf('.') > -1)
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
