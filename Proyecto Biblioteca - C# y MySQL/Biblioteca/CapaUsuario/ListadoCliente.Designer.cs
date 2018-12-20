namespace CapaUsuario
{
    partial class ListadoCliente
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonVer = new System.Windows.Forms.Button();
            this.listBoxListado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(137, 254);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(78, 33);
            this.buttonVolver.TabIndex = 5;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonVer
            // 
            this.buttonVer.Location = new System.Drawing.Point(34, 254);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(85, 33);
            this.buttonVer.TabIndex = 4;
            this.buttonVer.Text = "Ver";
            this.buttonVer.UseVisualStyleBackColor = true;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // listBoxListado
            // 
            this.listBoxListado.FormattingEnabled = true;
            this.listBoxListado.Location = new System.Drawing.Point(23, 34);
            this.listBoxListado.Name = "listBoxListado";
            this.listBoxListado.Size = new System.Drawing.Size(213, 199);
            this.listBoxListado.TabIndex = 3;
            // 
            // ListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 320);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonVer);
            this.Controls.Add(this.listBoxListado);
            this.Name = "ListadoCliente";
            this.Text = "ListadoCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.ListBox listBoxListado;
    }
}