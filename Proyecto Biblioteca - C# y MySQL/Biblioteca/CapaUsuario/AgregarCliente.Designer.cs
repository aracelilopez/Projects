namespace CapaUsuario
{
    partial class AgregarCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.ACEPTAR = new System.Windows.Forms.Button();
            this.CANCELAR = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonEspecial = new System.Windows.Forms.RadioButton();
            this.radioButtonComun = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE CÓDIGO SOCIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESE NOMBRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "INGRESE APELLIDO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "INGRESE LOCALIDAD:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(193, 86);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(167, 20);
            this.textBoxCodigo.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(193, 158);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(167, 20);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(193, 190);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(167, 20);
            this.textBoxApellido.TabIndex = 8;
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(193, 223);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(167, 20);
            this.textBoxLocalidad.TabIndex = 9;
            // 
            // ACEPTAR
            // 
            this.ACEPTAR.Location = new System.Drawing.Point(78, 268);
            this.ACEPTAR.Name = "ACEPTAR";
            this.ACEPTAR.Size = new System.Drawing.Size(96, 46);
            this.ACEPTAR.TabIndex = 10;
            this.ACEPTAR.Text = "Aceptar";
            this.ACEPTAR.UseVisualStyleBackColor = true;
            this.ACEPTAR.Click += new System.EventHandler(this.ACEPTAR_Click);
            // 
            // CANCELAR
            // 
            this.CANCELAR.Location = new System.Drawing.Point(203, 268);
            this.CANCELAR.Name = "CANCELAR";
            this.CANCELAR.Size = new System.Drawing.Size(95, 46);
            this.CANCELAR.TabIndex = 11;
            this.CANCELAR.Text = "Cancelar";
            this.CANCELAR.UseVisualStyleBackColor = true;
            this.CANCELAR.Click += new System.EventHandler(this.CANCELAR_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "INGRESE DNI:";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(193, 121);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(167, 20);
            this.textBoxDni.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "INDIQUE SI SERÁ ESPECIAL O COMÚN";
            // 
            // radioButtonEspecial
            // 
            this.radioButtonEspecial.AutoSize = true;
            this.radioButtonEspecial.Location = new System.Drawing.Point(81, 41);
            this.radioButtonEspecial.Name = "radioButtonEspecial";
            this.radioButtonEspecial.Size = new System.Drawing.Size(76, 17);
            this.radioButtonEspecial.TabIndex = 15;
            this.radioButtonEspecial.TabStop = true;
            this.radioButtonEspecial.Text = "ESPECIAL";
            this.radioButtonEspecial.UseVisualStyleBackColor = true;
            // 
            // radioButtonComun
            // 
            this.radioButtonComun.AutoSize = true;
            this.radioButtonComun.Location = new System.Drawing.Point(225, 41);
            this.radioButtonComun.Name = "radioButtonComun";
            this.radioButtonComun.Size = new System.Drawing.Size(65, 17);
            this.radioButtonComun.TabIndex = 16;
            this.radioButtonComun.TabStop = true;
            this.radioButtonComun.Text = "COMÚN";
            this.radioButtonComun.UseVisualStyleBackColor = true;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 333);
            this.Controls.Add(this.radioButtonComun);
            this.Controls.Add(this.radioButtonEspecial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CANCELAR);
            this.Controls.Add(this.ACEPTAR);
            this.Controls.Add(this.textBoxLocalidad);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AgregarCliente";
            this.Text = "AgregarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.Button ACEPTAR;
        private System.Windows.Forms.Button CANCELAR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonEspecial;
        private System.Windows.Forms.RadioButton radioButtonComun;
    }
}