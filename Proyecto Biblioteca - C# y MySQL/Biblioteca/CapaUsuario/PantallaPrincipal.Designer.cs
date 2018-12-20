namespace CapaUsuario
{
    partial class PantallaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darAltaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.darBajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aUnSoloEjemplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTodosLosEjemplaresDeUnLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarReservasVencidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarPrestamoPorCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarReservaPorCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Libro = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Prestamo = new System.Windows.Forms.Button();
            this.Devolver = new System.Windows.Forms.Button();
            this.Reserva = new System.Windows.Forms.Button();
            this.Renovar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.descripcionesToolStripMenuItem,
            this.listadoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(295, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libroToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menú";
            // 
            // libroToolStripMenuItem
            // 
            this.libroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darAltaToolStripMenuItem1,
            this.darBajaToolStripMenuItem1});
            this.libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            this.libroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.libroToolStripMenuItem.Text = "Libro";
            // 
            // darAltaToolStripMenuItem1
            // 
            this.darAltaToolStripMenuItem1.Name = "darAltaToolStripMenuItem1";
            this.darAltaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.darAltaToolStripMenuItem1.Text = "Dar Alta";
            this.darAltaToolStripMenuItem1.Click += new System.EventHandler(this.darAltaToolStripMenuItem1_Click);
            // 
            // darBajaToolStripMenuItem1
            // 
            this.darBajaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUnSoloEjemplarToolStripMenuItem,
            this.aTodosLosEjemplaresDeUnLibroToolStripMenuItem});
            this.darBajaToolStripMenuItem1.Name = "darBajaToolStripMenuItem1";
            this.darBajaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.darBajaToolStripMenuItem1.Text = "Dar Baja";
            // 
            // aUnSoloEjemplarToolStripMenuItem
            // 
            this.aUnSoloEjemplarToolStripMenuItem.Name = "aUnSoloEjemplarToolStripMenuItem";
            this.aUnSoloEjemplarToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.aUnSoloEjemplarToolStripMenuItem.Text = "A un solo ejemplar";
            this.aUnSoloEjemplarToolStripMenuItem.Click += new System.EventHandler(this.aUnSoloEjemplarToolStripMenuItem_Click);
            // 
            // aTodosLosEjemplaresDeUnLibroToolStripMenuItem
            // 
            this.aTodosLosEjemplaresDeUnLibroToolStripMenuItem.Name = "aTodosLosEjemplaresDeUnLibroToolStripMenuItem";
            this.aTodosLosEjemplaresDeUnLibroToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.aTodosLosEjemplaresDeUnLibroToolStripMenuItem.Text = "A todos los ejemplares de un libro";
            this.aTodosLosEjemplaresDeUnLibroToolStripMenuItem.Click += new System.EventHandler(this.aTodosLosEjemplaresDeUnLibroToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darAltaToolStripMenuItem,
            this.darBajaToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // darAltaToolStripMenuItem
            // 
            this.darAltaToolStripMenuItem.Name = "darAltaToolStripMenuItem";
            this.darAltaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darAltaToolStripMenuItem.Text = "Dar Alta";
            this.darAltaToolStripMenuItem.Click += new System.EventHandler(this.darAltaToolStripMenuItem_Click);
            // 
            // darBajaToolStripMenuItem
            // 
            this.darBajaToolStripMenuItem.Name = "darBajaToolStripMenuItem";
            this.darBajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darBajaToolStripMenuItem.Text = "Dar Baja";
            this.darBajaToolStripMenuItem.Click += new System.EventHandler(this.darBajaToolStripMenuItem_Click);
            // 
            // descripcionesToolStripMenuItem
            // 
            this.descripcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesPendientesToolStripMenuItem,
            this.limpiarReservasVencidasToolStripMenuItem,
            this.mostrarPrestamoPorCodigoToolStripMenuItem,
            this.mostrarReservaPorCodigoToolStripMenuItem});
            this.descripcionesToolStripMenuItem.Name = "descripcionesToolStripMenuItem";
            this.descripcionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.descripcionesToolStripMenuItem.Text = "Descripciones";
            // 
            // clientesPendientesToolStripMenuItem
            // 
            this.clientesPendientesToolStripMenuItem.Name = "clientesPendientesToolStripMenuItem";
            this.clientesPendientesToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.clientesPendientesToolStripMenuItem.Text = "Clientes con prestamo Pendiente";
            this.clientesPendientesToolStripMenuItem.Click += new System.EventHandler(this.clientesPendientesToolStripMenuItem_Click);
            // 
            // limpiarReservasVencidasToolStripMenuItem
            // 
            this.limpiarReservasVencidasToolStripMenuItem.Name = "limpiarReservasVencidasToolStripMenuItem";
            this.limpiarReservasVencidasToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.limpiarReservasVencidasToolStripMenuItem.Text = "Limpiar Reservas Vencidas";
            this.limpiarReservasVencidasToolStripMenuItem.Click += new System.EventHandler(this.limpiarReservasVencidasToolStripMenuItem_Click);
            // 
            // mostrarPrestamoPorCodigoToolStripMenuItem
            // 
            this.mostrarPrestamoPorCodigoToolStripMenuItem.Name = "mostrarPrestamoPorCodigoToolStripMenuItem";
            this.mostrarPrestamoPorCodigoToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.mostrarPrestamoPorCodigoToolStripMenuItem.Text = "Mostrar Prestamo por código";
            this.mostrarPrestamoPorCodigoToolStripMenuItem.Click += new System.EventHandler(this.mostrarPrestamoPorCodigoToolStripMenuItem_Click);
            // 
            // mostrarReservaPorCodigoToolStripMenuItem
            // 
            this.mostrarReservaPorCodigoToolStripMenuItem.Name = "mostrarReservaPorCodigoToolStripMenuItem";
            this.mostrarReservaPorCodigoToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.mostrarReservaPorCodigoToolStripMenuItem.Text = "Mostrar Reserva por código";
            this.mostrarReservaPorCodigoToolStripMenuItem.Click += new System.EventHandler(this.mostrarReservaPorCodigoToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Libro,
            this.clientesToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.reservasToolStripMenuItem});
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // Libro
            // 
            this.Libro.Name = "Libro";
            this.Libro.Size = new System.Drawing.Size(180, 22);
            this.Libro.Text = "Libros";
            this.Libro.Click += new System.EventHandler(this.Libro_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            this.prestamosToolStripMenuItem.Click += new System.EventHandler(this.prestamosToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Prestamo
            // 
            this.Prestamo.Location = new System.Drawing.Point(45, 37);
            this.Prestamo.Name = "Prestamo";
            this.Prestamo.Size = new System.Drawing.Size(201, 34);
            this.Prestamo.TabIndex = 1;
            this.Prestamo.Text = "Prestamo de Libro";
            this.Prestamo.UseVisualStyleBackColor = true;
            this.Prestamo.Click += new System.EventHandler(this.Prestamo_Click);
            // 
            // Devolver
            // 
            this.Devolver.Location = new System.Drawing.Point(45, 94);
            this.Devolver.Name = "Devolver";
            this.Devolver.Size = new System.Drawing.Size(201, 35);
            this.Devolver.TabIndex = 2;
            this.Devolver.Text = "Devolución de Libro";
            this.Devolver.UseVisualStyleBackColor = true;
            this.Devolver.Click += new System.EventHandler(this.Devolver_Click);
            // 
            // Reserva
            // 
            this.Reserva.Location = new System.Drawing.Point(45, 155);
            this.Reserva.Name = "Reserva";
            this.Reserva.Size = new System.Drawing.Size(201, 39);
            this.Reserva.TabIndex = 3;
            this.Reserva.Text = "Reservar Un libro";
            this.Reserva.UseVisualStyleBackColor = true;
            this.Reserva.Click += new System.EventHandler(this.Reserva_Click);
            // 
            // Renovar
            // 
            this.Renovar.Location = new System.Drawing.Point(45, 216);
            this.Renovar.Name = "Renovar";
            this.Renovar.Size = new System.Drawing.Size(201, 41);
            this.Renovar.TabIndex = 4;
            this.Renovar.Text = "Renovar Prestamo";
            this.Renovar.UseVisualStyleBackColor = true;
            this.Renovar.Click += new System.EventHandler(this.Renovar_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 289);
            this.Controls.Add(this.Renovar);
            this.Controls.Add(this.Reserva);
            this.Controls.Add(this.Devolver);
            this.Controls.Add(this.Prestamo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darAltaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem darBajaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aUnSoloEjemplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTodosLosEjemplaresDeUnLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darAltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button Prestamo;
        private System.Windows.Forms.Button Devolver;
        private System.Windows.Forms.Button Reserva;
        private System.Windows.Forms.Button Renovar;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Libro;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesPendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarReservasVencidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarPrestamoPorCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarReservaPorCodigoToolStripMenuItem;

    }
}