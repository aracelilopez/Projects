namespace CapaUsuario
{
    partial class ListadoLibro
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonVer = new System.Windows.Forms.Button();
            this.listBoxListado = new System.Windows.Forms.ListBox();
            this.ButtonSeleccionar = new System.Windows.Forms.Button();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(260, 257);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(78, 33);
            this.buttonVolver.TabIndex = 8;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonVer
            // 
            this.buttonVer.Location = new System.Drawing.Point(128, 257);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(85, 33);
            this.buttonVer.TabIndex = 7;
            this.buttonVer.Text = "Ver";
            this.buttonVer.UseVisualStyleBackColor = true;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // listBoxListado
            // 
            this.listBoxListado.FormattingEnabled = true;
            this.listBoxListado.Location = new System.Drawing.Point(23, 35);
            this.listBoxListado.Name = "listBoxListado";
            this.listBoxListado.Size = new System.Drawing.Size(384, 199);
            this.listBoxListado.TabIndex = 6;
            // 
            // ButtonSeleccionar
            // 
            this.ButtonSeleccionar.Location = new System.Drawing.Point(472, 74);
            this.ButtonSeleccionar.Name = "ButtonSeleccionar";
            this.ButtonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.ButtonSeleccionar.TabIndex = 17;
            this.ButtonSeleccionar.Text = "Seleccionar";
            this.ButtonSeleccionar.UseVisualStyleBackColor = true;
            this.ButtonSeleccionar.Click += new System.EventHandler(this.ButtonSeleccionar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonGenero);
            this.panel1.Controls.Add(this.radioButtonEditorial);
            this.panel1.Controls.Add(this.radioButtonAutor);
            this.panel1.Controls.Add(this.radioIsbn);
            this.panel1.Controls.Add(this.buttonFiltrar);
            this.panel1.Controls.Add(this.textBoxFiltro);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(413, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 128);
            this.panel1.TabIndex = 16;
            // 
            // radioButtonGenero
            // 
            this.radioButtonGenero.AutoSize = true;
            this.radioButtonGenero.Location = new System.Drawing.Point(99, 80);
            this.radioButtonGenero.Name = "radioButtonGenero";
            this.radioButtonGenero.Size = new System.Drawing.Size(76, 17);
            this.radioButtonGenero.TabIndex = 12;
            this.radioButtonGenero.TabStop = true;
            this.radioButtonGenero.Text = "por género";
            this.radioButtonGenero.UseVisualStyleBackColor = true;
            // 
            // radioButtonEditorial
            // 
            this.radioButtonEditorial.AutoSize = true;
            this.radioButtonEditorial.Location = new System.Drawing.Point(99, 57);
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
            this.radioButtonAutor.Location = new System.Drawing.Point(26, 80);
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
            this.radioIsbn.Location = new System.Drawing.Point(26, 57);
            this.radioIsbn.Name = "radioIsbn";
            this.radioIsbn.Size = new System.Drawing.Size(68, 17);
            this.radioIsbn.TabIndex = 9;
            this.radioIsbn.TabStop = true;
            this.radioIsbn.Text = "por ISBN";
            this.radioIsbn.UseVisualStyleBackColor = true;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(59, 105);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 8;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(35, 21);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(120, 20);
            this.textBoxFiltro.TabIndex = 6;
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Location = new System.Drawing.Point(523, 51);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(41, 17);
            this.radioButtonNO.TabIndex = 15;
            this.radioButtonNO.TabStop = true;
            this.radioButtonNO.Text = "NO";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Location = new System.Drawing.Point(453, 51);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(35, 17);
            this.radioButtonSi.TabIndex = 14;
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.Text = "SI";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "¿Desea algún filtro?";
            // 
            // ListadoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 326);
            this.Controls.Add(this.ButtonSeleccionar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButtonNO);
            this.Controls.Add(this.radioButtonSi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonVer);
            this.Controls.Add(this.listBoxListado);
            this.Controls.Add(this.label1);
            this.Name = "ListadoLibro";
            this.Text = "ListadoLibro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.ListBox listBoxListado;
        private System.Windows.Forms.Button ButtonSeleccionar;
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
    }
}