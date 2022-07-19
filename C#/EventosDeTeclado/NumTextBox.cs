using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosDeTeclado
{
    public class NumTextBox : TextBox
    {
        private bool aceptapunto = true;
        private delegate bool Delegado(char E);
        Delegado analizaKeychar;

        public NumTextBox()
        {
            analizaKeychar = conPunto;
        }

      
        //comportamiento
        public bool AceptaPunto
        {
            set
            {
                aceptapunto = value;
                if (aceptapunto)
                    analizaKeychar = conPunto;
                else
                    analizaKeychar = sinPunto;
            }
            get { return aceptapunto; }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!analizaKeychar(e.KeyChar))
            {
                e.Handled = true;
            }
            if (base.Text.Contains(".") && (e.KeyChar == '.') && aceptapunto)
            {
                e.Handled = true;
            }
        }

        protected override void OnLeave(System.EventArgs e)
        {
            base.OnLeave(e);
            if (aceptapunto)
            {
                if (base.Text.StartsWith("."))
                {
                    base.Text = base.Text.Insert(0, "0");
                }
            }
        }

        private bool conPunto(char E)
        {
            return (char.IsDigit(E) || char.IsControl(E) || E == '.');
        }

        private bool sinPunto(char E)
        {
            return (char.IsDigit(E) || char.IsControl(E));
        }
    }
}
