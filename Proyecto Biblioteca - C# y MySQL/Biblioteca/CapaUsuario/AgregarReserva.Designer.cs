namespace CapaUsuario
{
    partial class AgregarReserva
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
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonSeleccionar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRealizar = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonGenero = new System.Windows.Forms.RadioButton();
            this.radioButtonEditorial = new System.Windows.Forms.RadioButton();
            this.radioButtonAutor = new System.Windows.Forms.RadioButton();
            this.radioIsbn = new System.Windows.Forms.RadioButton();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.radioButtonSi = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(219, 9);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(187, 20);
            this.textBoxCodigo.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "INGRESE UN CÓDIGO DE RESERVA:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 38);
            this.button1.TabIndex = 29;
            this.button1.Text = "Buscar Cliente por código";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "LISTADO DE LIBROS";
            // 
            // ButtonSeleccionar
            // 
            this.ButtonSeleccionar.Location = new System.Drawing.Point(257, 110);
            this.ButtonSeleccionar.Name = "ButtonSeleccionar";
            this.ButtonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.ButtonSeleccionar.TabIndex = 27;
            this.ButtonSeleccionar.Text = "Seleccionar";
            this.ButtonSeleccionar.UseVisualStyleBackColor = true;
            this.ButtonSeleccionar.Click += new System.EventHandler(this.ButtonSeleccionar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(217, 414);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(107, 48);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonRealizar
            // 
            this.buttonRealizar.Location = new System.Drawing.Point(82, 414);
            this.buttonRealizar.Name = "buttonRealizar";
            this.buttonRealizar.Size = new System.Drawing.Size(106, 48);
            this.buttonRealizar.TabIndex = 25;
            this.buttonRealizar.Text = "Realzar Reserva";
            this.buttonRealizar.UseVisualStyleBackColor = true;
            this.buttonRealizar.Click += new System.EventHandler(this.buttonRealizar_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(67, 313);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(282, 95);
            this.listBox2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonGenero);
            this.panel1.Controls.Add(this.radioButtonEditorial);
            this.panel1.Controls.Add(this.radioButtonAutor);
            this.panel1.Controls.Add(this.radioIsbn);
            this.panel1.Controls.Add(this.buttonFiltrar);
            this.panel1.Controls.Add(this.textBoxFiltro);
            this.panel1.Location = new System.Drawing.Point(198, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 149);
            this.panel1.TabIndex = 23;
            // 
            // radioButtonGenero
            // 
            this.radioButtonGenero.AutoSize = true;
            this.radioButtonGenero.Location = new System.Drawing.Point(104, 80);
            this.radioButtonGenero.Name = "radioButtonGenero";
            this.radioButtonGenero.Size = new System.Drawing.Size(76, 17);
            this.radioButtonGenero.TabIndex = 12;
            this.radioButtonGenero.TabStop = true;
            this.radioButtonGenero.Text = "por genero";
            this.radioButtonGenero.UseVisualStyleBackColor = true;
            // 
            // radioButtonEditorial
            // 
            this.radioButtonEditorial.AutoSize = true;
            this.radioButtonEditorial.Location = new System.Drawing.Point(104, 57);
            this.radioButtonEditorial.Name = "radioButtonEditorial";
            this.radioButtonEditorial.Size = new System.Drawing.Size(79, 17);
            this.radioButtonEditorial.TabIndex = 11;
            this.radioButtonEditorial.TabStop = true;
            this.radioButtonEditorial.Text = "por editorial";
            this.radioButtonEditorial.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutor
            // 
            this.radioButtonAutor.AutoSize = true;
            this.radioButtonAutor.Location = new System.Drawing.Point(31, 80);
            this.radioButtonAutor.Name = "radioButtonAutor";
            this.radioButtonAutor.Size = new System.Drawing.Size(67, 17);
            this.radioButtonAutor.TabIndex = 10;
            this.radioButtonAutor.TabStop = true;
            this.radioButtonAutor.Text = "por autor";
            this.radioButtonAutor.UseVisualStyleBackColor = true;
            // 
            // radioIsbn
            // 
            this.radioIsbn.AutoSize = true;
            this.radioIsbn.Location = new System.Drawing.Point(31, 57);
            this.radioIsbn.Name = "radioIsbn";
            this.radioIsbn.Size = new System.Drawing.Size(68, 17);
            this.radioIsbn.TabIndex = 9;
            this.radioIsbn.TabStop = true;
            this.radioIsbn.Text = "por ISBN";
            this.radioIsbn.UseVisualStyleBackColor = true;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(59, 123);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 8;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(40, 12);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(120, 20);
            this.textBoxFiltro.TabIndex = 6;
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Location = new System.Drawing.Point(308, 87);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(41, 17);
            this.radioButtonNO.TabIndex = 22;
            this.radioButtonNO.TabStop = true;
            this.radioButtonNO.Text = "NO";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Location = new System.Drawing.Point(238, 87);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(35, 17);
            this.radioButtonSi.TabIndex = 21;
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.Text = "SI";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "¿Desea algún filtro?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "LISTA DE LIBROS";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 160);
            this.listBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "LISTA DE CLIENTES";
            // 
            // AgregarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 477);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonSeleccionar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRealizar);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButtonNO);
            this.Controls.Add(this.radioButtonSi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "AgregarReserva";
            this.Text = "AgregarReserva";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonSeleccionar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonRealizar;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonGenero;
        private System.Windows.Forms.RadioButton radioButtonEditorial;
        private System.Windows.Forms.RadioButton radioButtonAutor;
        private System.Windows.Forms.RadioButton radioIsbn;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.RadioButton radioButtonNO;
        private System.Windows.Forms.RadioButton radioButtonSi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}