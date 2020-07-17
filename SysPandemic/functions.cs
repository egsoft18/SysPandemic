using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPandemic
{
    class functions
    {

        public void limpiar(Form f)
        {
            foreach (Control oControls in f.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = "";
                }
            }

        }

        public void starttext(MaskedTextBox txt)
        {
            if (txt.Text.Length <= 0)
            {
                txt.Select(0, 0);
            }

        }

        public static void onlyletters(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                //MessageBox.Show("Solo Letras.");
            }
        }

        public static void onlynumbers(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                //MessageBox.Show("Solo Numeros.");
            }
        }

        public static void onlylettersnumbers(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                //MessageBox.Show("Solo Numeros.");
            }
        }

        public static void onlydecimals(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                //MessageBox.Show("Solo numeros o numeros con punto decimal.");
            }
        }
    }
}
