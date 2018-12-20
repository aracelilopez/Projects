using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocio;


namespace CapaUsuario
{
    public partial class PantallaPrincipal : Form
    {
        Administradora admin;

        public PantallaPrincipal()
        {
            InitializeComponent();
            admin = new Administradora("Araceli");
            MessageBox.Show("Bienvenidos a la biblioteca de: " + "Quilmes");

             admin.cargarDatosDesdeBD();
        }

        private void darAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCliente agregar = new AgregarCliente();
            agregar.ShowDialog();
            Cliente cli = agregar.darcliente();
            

            if(cli != null)
            {
                if (admin.agregarCliente(cli))
                {
                    MessageBox.Show("EL CLIENTE SE GUARDO CON EXITO EN LA BD");
                }
                else
                    MessageBox.Show("No se pudo guardar, el ID ya existe");
            }
        }

        private void darBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCliente2 eliminar = new EliminarCliente2(admin);
            eliminar.ShowDialog();

            admin = eliminar.daradmin();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoCliente listado = new ListadoCliente(admin.Listaclientes);
            listado.ShowDialog();

        }

        private void darAltaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregarLibro agregar = new AgregarLibro();
            agregar.ShowDialog();
            Libro lib = agregar.darlibro();

            if(lib != null)
            {
                if(admin.agregarLibro(lib))
                {
                    MessageBox.Show("Se ha agregado el libro con exito a la BD");
                }
                else
                    MessageBox.Show("No se pudo agregar el libro");
            }
        }

        private void aUnSoloEjemplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarLibroEjemplar eliminar = new EliminarLibroEjemplar();
            eliminar.ShowDialog();
            int isbn = eliminar.darisbn();
            int ejemplar = eliminar.darejemplar();

            if(isbn != 0 && ejemplar != 0)
            {
                if (admin.eliminarlibro(isbn, ejemplar))
                {
                    admin.limpiarPrestamoxLibro(isbn, ejemplar);
                    admin.limpiarReservasxLibro(isbn, ejemplar);
                    MessageBox.Show("Se ha eliminado con exito de la BD");
                }
                else
                    MessageBox.Show("No se pudo eliminar el ejemplar de la BD");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta luego");
            this.Close();

        }

        private void Prestamo_Click(object sender, EventArgs e)
        {
            CrearPrestamo prestamo = new CrearPrestamo(admin);
            prestamo.ShowDialog();
            admin = prestamo.Daradministradora();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoPrestamo listado = new ListadoPrestamo(admin);
            listado.ShowDialog();

            Administradora copiaadmin = listado.daradmin();

            admin = copiaadmin;
        }

  

        private void Libro_Click(object sender, EventArgs e)
        {
            ListadoLibro listado = new ListadoLibro(admin);
            listado.ShowDialog();
            
        }

        private void Devolver_Click(object sender, EventArgs e)
        {
            DevolucionPrestamo devolver = new DevolucionPrestamo();
            devolver.ShowDialog();

            int codigoCliente = devolver.devolverCodigo();
            int isbn = devolver.devolveIsbn();
            int ejemplar = devolver.devolverEjemplar();

            if(!(codigoCliente == 0 && isbn == 0 && ejemplar == 0))
            {
                Prestamo presta = admin.buscarPrestamoEspecifica(codigoCliente, isbn, ejemplar);
                if (presta == null)
                    MessageBox.Show("No se ha encontrado un prestamo con esos datos ingresados");
                else
                {
                    if (admin.devolucionLibro(presta.Libro))
                    {
                        if (admin.eliminarPrestamo(presta.Codigo))
                        {
                            MessageBox.Show("Se ha eliminado con exito");
                        }
                        else
                            MessageBox.Show("No se ha podido eliminar por algun problema");
                    }
                    else
                        MessageBox.Show("Algo salio mal en volver a guardar el libro en la biblioteca");
                }
            }
                
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoReservas listado = new ListadoReservas(admin);
            listado.ShowDialog();

            Administradora copiaadmin = listado.daradmin();

            admin = copiaadmin;
        }

        private void Reserva_Click(object sender, EventArgs e)
        {
            AgregarReserva agregar = new AgregarReserva(admin);
            agregar.ShowDialog();
            admin = agregar.devolverAdmin();
        }

        private void Renovar_Click(object sender, EventArgs e)
        {
            
                DevolucionPrestamo renovar = new DevolucionPrestamo();
                renovar.ShowDialog();
                int codigocli = renovar.devolverCodigo();
                int isbn = renovar.devolveIsbn();
                int ejemplar = renovar.devolverEjemplar();

                
                    Prestamo pres = admin.buscarPrestamoEspecifica(codigocli, isbn, ejemplar);

                    if (pres != null)
                    {
                        if (admin.ahireserva(isbn, ejemplar))
                            MessageBox.Show("Existe una o más reservas asi que no se puede renovar el prestamo");
                        else
                        {
                            if (admin.renovarPrestamo(pres))
                                MessageBox.Show("Se ha renovado el vencimiento de el prestamo");
                            else
                                MessageBox.Show("Algo salio mal y no se ha modificado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado un prestamo con esos datos");
                    }
        }

        private void limpiarReservasVencidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Usted, está seguro de querer limpiar la lista de reservas? ", "ALERTA", MessageBoxButtons.YesNo);

            if(boton == DialogResult.Yes)
            {
                admin.limpiarReservasVencidas();
                ListadoReservas listado = new ListadoReservas(admin);
                listado.ShowDialog();
                Administradora admincopia = listado.daradmin();
                admin = admincopia;
            }
        }

        private void clientesPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cliente> clientespendientes = admin.clientesPendientes();
            ListadoCliente listado = new ListadoCliente(clientespendientes);
            listado.ShowDialog();
        }

        private void mostrarPrestamoPorCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPrestamoReserva buscar = new BuscarPrestamoReserva();
            buscar.ShowDialog();
            int codigo = buscar.darcodigo();

            if(codigo != 0)
            {
                Prestamo pres = admin.buscarprestamo(codigo);

                if (pres != null)
                {
                    MostrarPrestamo2 mostrar = new MostrarPrestamo2(pres);
                    mostrar.ShowDialog();
                }
                else
                    MessageBox.Show("No se ha encontrado un prestamo con este código");
            }
        }

        private void mostrarReservaPorCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPrestamoReserva buscar = new BuscarPrestamoReserva();
            buscar.ShowDialog();
            int codigo = buscar.darcodigo();

            if (codigo != 0)
            {
                Reserva Res = admin.buscarreserva(codigo);

                if (Res != null)
                {
                    MostrarReserva mostrar = new MostrarReserva(Res);
                    mostrar.ShowDialog();
                }
                else
                    MessageBox.Show("No se ha encontrado una Reserva con este código");
               
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void aTodosLosEjemplaresDeUnLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarLibros eli = new EliminarLibros();
            eli.ShowDialog();
            int isbn = eli.darisbn();
            if(isbn != 0)
            {
                if (admin.eliminarlibro(isbn) > 0)
                {
                    admin.limpiarReservasxLibro(isbn);
                    admin.limpiarPrestamoxLibro(isbn);
                    MessageBox.Show("Se ha eliminado con exito de la BD");
                }
                else
                    MessageBox.Show("No se ha podido eliminar el ejemplar de la BD");
            }
        }

    }
}
