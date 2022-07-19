using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosDeTeclado
{
    public partial class Form1 : Form
    {

        
        //Bandera a usar para determinar cuando el caracter es numero
        private bool nonNumberEntered = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            mtbFechaNacimiento.Mask = "00/00/0000";
            mtbFechaNacimiento.MaskInputRejected += new MaskInputRejectedEventHandler(mtbFechaNacimiento_MaskInputRejected);
            mtbFechaNacimiento.KeyDown += new KeyEventHandler(mtbFechaNacimiento_KeyDown);
            mtbSueldo.ValidatingType = typeof(System.Double);
            mtbSueldo.TypeValidationCompleted += new TypeValidationEventHandler(mtbSueldo_TypeValidationCompleted);
    
        }

        void mtbFechaNacimiento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbFechaNacimiento.MaskFull)
            {
                ttFecha.ToolTipTitle = "Entrada rechazada. Demasiados datos";
                ttFecha.Show("Usted no puede ingresar mas datos. " +
                    "Elimine caracteres si desea seguir añadiendo", mtbFechaNacimiento, 0, -20, 2000);
            }
            else if (e.Position == mtbFechaNacimiento.Mask.Length)
            {
                ttFecha.ToolTipTitle = "Entrada Rechazada. Campo totalmente lleno";
                ttFecha.Show("You cannot add extra characters to the end of this date field.", mtbFechaNacimiento, 0, -20,2000);
            }
            else
            {
                ttFecha.ToolTipTitle = "Entrada Rechazada";
                ttFecha.Show("Usted solamente puede ingresar números en este campo.", mtbFechaNacimiento, 0, -20, 2000);
            }
        }

        void mtbFechaNacimiento_KeyDown(object sender, KeyEventArgs e)
        {
            
            ttFecha.Hide(mtbFechaNacimiento);
        }

        public void mtbSueldo_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                ttSueldo.ToolTipTitle = "Dato Inválido";
                ttSueldo.Show("Lo sentimos, no es válida su entrada. Por favor, cambie de valor", mtbSueldo, 2000);
                e.Cancel = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Mira la bandera creada en el evento keydown

            if (!nonNumberEntered == true)
            {
                //Para el caracter si no es numérico
                e.Handled = true;
            }
        }

        // Handle del KeyDown evento para determinar el tipo de caracter ingresado
        private void txtNombre_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Inicializa la bandera en falso
            nonNumberEntered = false;

            // Determina si el ingresado son los numeros de arriba del teclado
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determina si es numero del KeyPad
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Si es espacio
                    if (e.KeyCode != Keys.Back)
                    {
                        // Algo no numero ha sido presionado y steamos la bandera en true !
                        nonNumberEntered = true;
                    }
                }
            }
            //si shift key ha sido presionado, no ha sido numero
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

    }
}
