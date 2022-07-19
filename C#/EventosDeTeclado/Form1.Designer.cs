
namespace EventosDeTeclado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mtbCedula = new System.Windows.Forms.MaskedTextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.ttFecha = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.mtbSueldo = new System.Windows.Forms.MaskedTextBox();
            this.ttSueldo = new System.Windows.Forms.ToolTip(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoloText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.ntbCelolar = new EventosDeTeclado.NumTextBox();
            this.SuspendLayout();
            // 
            // mtbCedula
            // 
            this.mtbCedula.Location = new System.Drawing.Point(152, 93);
            this.mtbCedula.Mask = "000000000-0";
            this.mtbCedula.Name = "mtbCedula";
            this.mtbCedula.Size = new System.Drawing.Size(100, 20);
            this.mtbCedula.TabIndex = 1;
            this.mtbCedula.ValidatingType = typeof(int);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(99, 96);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(43, 13);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cedula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Nacimiento:";
            // 
            // mtbFechaNacimiento
            // 
            this.mtbFechaNacimiento.Location = new System.Drawing.Point(152, 140);
            this.mtbFechaNacimiento.Name = "mtbFechaNacimiento";
            this.mtbFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.mtbFechaNacimiento.TabIndex = 2;
            this.mtbFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sueldo:";
            // 
            // mtbSueldo
            // 
            this.mtbSueldo.Location = new System.Drawing.Point(152, 191);
            this.mtbSueldo.Name = "mtbSueldo";
            this.mtbSueldo.Size = new System.Drawing.Size(100, 20);
            this.mtbSueldo.TabIndex = 3;
            this.mtbSueldo.ValidatingType = typeof(int);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(152, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre:";
            // 
            // lblSoloText
            // 
            this.lblSoloText.AutoSize = true;
            this.lblSoloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoloText.ForeColor = System.Drawing.Color.Red;
            this.lblSoloText.Location = new System.Drawing.Point(100, 243);
            this.lblSoloText.Name = "lblSoloText";
            this.lblSoloText.Size = new System.Drawing.Size(50, 13);
            this.lblSoloText.TabIndex = 9;
            this.lblSoloText.Text = "Celolar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password:";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(152, 47);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(100, 20);
            this.txtContrasenia.TabIndex = 10;
            // 
            // ntbCelolar
            // 
            this.ntbCelolar.AceptaPunto = true;
            this.ntbCelolar.Location = new System.Drawing.Point(152, 240);
            this.ntbCelolar.MaxLength = 10;
            this.ntbCelolar.Name = "ntbCelolar";
            this.ntbCelolar.Size = new System.Drawing.Size(100, 20);
            this.ntbCelolar.TabIndex = 4;
            this.ntbCelolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 286);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.lblSoloText);
            this.Controls.Add(this.ntbCelolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.mtbSueldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbFechaNacimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.mtbCedula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbFechaNacimiento;
        private System.Windows.Forms.ToolTip ttFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbSueldo;
        private System.Windows.Forms.ToolTip ttSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private NumTextBox ntbCelolar;
        private System.Windows.Forms.Label lblSoloText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContrasenia;
    }
}

