namespace CapaUsuario
{
    partial class DevolucionPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCodigoSocio = new System.Windows.Forms.TextBox();
            this.textBoxCodigoIsbn = new System.Windows.Forms.TextBox();
            this.textBoxEjemplar = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE CÓDIGO DE SOCIO:";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE CÓDIGO ISBN DEL LIBRO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESE NÚMERO DE EJEMPLAR:";
            // 
            // textBoxCodigoSocio
            // 
            this.textBoxCodigoSocio.Location = new System.Drawing.Point(254, 10);
            this.textBoxCodigoSocio.Name = "textBoxCodigoSocio";
            this.textBoxCodigoSocio.Size = new System.Drawing.Size(160, 20);
            this.textBoxCodigoSocio.TabIndex = 3;
            // 
            // textBoxCodigoIsbn
            // 
            this.textBoxCodigoIsbn.Location = new System.Drawing.Point(254, 50);
            this.textBoxCodigoIsbn.Name = "textBoxCodigoIsbn";
            this.textBoxCodigoIsbn.Size = new System.Drawing.Size(160, 20);
            this.textBoxCodigoIsbn.TabIndex = 4;
            // 
            // textBoxEjemplar
            // 
            this.textBoxEjemplar.Location = new System.Drawing.Point(254, 88);
            this.textBoxEjemplar.Name = "textBoxEjemplar";
            this.textBoxEjemplar.Size = new System.Drawing.Size(160, 20);
            this.textBoxEjemplar.TabIndex = 5;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(91, 132);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(108, 48);
            this.Aceptar.TabIndex = 6;
            this.Aceptar.Text = "ACEPTAR";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.buttonDevolver_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(230, 132);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 48);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // DevolucionPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 192);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.textBoxEjemplar);
            this.Controls.Add(this.textBoxCodigoIsbn);
            this.Controls.Add(this.textBoxCodigoSocio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DevolucionPrestamo";
            this.Text = "Prestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCodigoSocio;
        private System.Windows.Forms.TextBox textBoxCodigoIsbn;
        private System.Windows.Forms.TextBox textBoxEjemplar;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}