using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Collections;

namespace CapaDeNegocio
{
    public class Administradora
    {
        private string nombre;
        private List<Cliente> listaclientes;
 
        private List<Libro> listalibros;
        private List<Prestamo> listaprestamos;
     
        private List<Reserva> listareservas;

        // CONSTRUCTOR

        public Administradora(string nom)
        {
            nombre = nom;
            listaclientes = new List<Cliente>();
          
            listalibros = new List<Libro>();
            listaprestamos = new List<Prestamo>();
            listareservas = new List<Reserva>();
            

        }

        // GETTER Y SETTER

        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public List<Cliente> Listaclientes
        {
            get
            {
                return listaclientes;
            }
            set
            {
                listaclientes = value;
            }
        }
        
        public List<Libro> Listalibros
        {
            get
            {
                return listalibros;
            }
            set
            {
                listalibros = value;
            }
        }
        public List<Prestamo> Listaprestamos
        {
            get
            {
                return listaprestamos;
            }
            set
            {
                listaprestamos = value;
            }
        }
        public List<Reserva> Listareservas
        {
            get
            {
                return listareservas;
            }
            set
            {
                listareservas = value;
            }
        }
      

        // LOS BUSCAR
        public Cliente buscarCliente(int codigo)
        {
            int i = 0;
            while (i < listaclientes.Count && listaclientes[i].CodigoSocio != codigo)
                i++;
            if (i == listaclientes.Count)
                return null;
            else
                return listaclientes[i];
        }

        

        public Libro buscarLibro(int isbn, int ejemplar)
        {
            int i = 0;
            while (i < listalibros.Count && (listalibros[i].Isbn != isbn || listalibros[i].Ejemplar != ejemplar))
                i++;
            if (i == listalibros.Count)
                return null;
            else
                return listalibros[i];
        }

        public Prestamo buscarprestamo(int codigoprestamo)
        {
            int i = 0;
            while (i < listaprestamos.Count && listaprestamos[i].Codigo != codigoprestamo)
                i++;
            if (i == listaprestamos.Count)
                return null;
            else
                return listaprestamos[i];
        }

        public Reserva buscarreserva(int codigoreserva)
        {
            int i = 0;
            while (i < listareservas.Count && listareservas[i].Codigo != codigoreserva)
                i++;
            if (i == listareservas.Count)
                return null;
            else
                return listareservas[i];
        }

      

        // LOS AGREGAR

        public bool agregarCliente(Cliente c)
        {

            Cliente cli = this.buscarCliente(c.CodigoSocio);

            if (cli != null)
                return false;
            else
            {
                listaclientes.Add(c);
                Datos.guardaCliente(c.desarmarObjeto());
                return true;
            }
        }

        public bool agregarLibro(Libro l)
        {

            Libro libro = this.buscarLibro(l.Isbn, l.Ejemplar);

            if (libro != null)
                return false;
            else
            {
                listalibros.Add(l);
                Datos.guardaLibro(l.desarmarObjeto());
                return true;
            }
        }

        public bool agregarPrestamo(Prestamo pre)
        {

            Prestamo presta = this.buscarprestamo(pre.Codigo);

            if (presta != null)
                return false;
            else
            {
                listaprestamos.Add(pre);
                Datos.guardaPrestamo(pre.desarmarObjeto());
                return true;
            }
        }

        public bool agregarReservas(Reserva re)
        {

            Reserva recer = this.buscarreserva(re.Codigo);

            if (recer != null)
                return false;
            else
            {
                listareservas.Add(re);
                Datos.guardaReserva(re.desarmarObjeto());
                return true;
            }
        }
      

        // LOS ELIMINAR

        public bool eliminarCliente(int cod)
        {
            Cliente cli = buscarCliente(cod);

            if (cli != null)
            {
                listaclientes.Remove(cli);
                Datos.eliminarCliente(cli.CodigoSocio);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminarlibro(int isbn, int ejemplar)
        {
            Libro li = buscarLibro(isbn, ejemplar);

            if (li != null)
            {
                listalibros.Remove(li);
                Datos.eliminarLibro(isbn, ejemplar);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int  eliminarlibro(int isbn)
        {
            int i = 0;
            int contador = 0;

            while(i < listalibros.Count)
            {
                if (listalibros[i].Isbn == isbn)
                {
                    contador++;
                    eliminarlibro(listalibros[i].Isbn, listalibros[i].Ejemplar);
                }
            }
            return contador;
            
        }

     

        public bool eliminarPrestamo(int cod)
        {
            Prestamo presta = this.buscarprestamo(cod);

            if (presta != null)
            {
                listaprestamos.Remove(presta);
                Datos.eliminarPrestamo(presta.Codigo);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminarReserva(int cod)
        {
            Reserva res = this.buscarreserva(cod);

            if (res != null)
            {
                listareservas.Remove(res);
                Datos.eliminarReserva(res.Codigo);
                return true;
            }
            else
            {
                return false;
            }
        }

        // LOS METODOS

        public List<Prestamo> prestamosxclientes(int codigo)
        {
            List<Prestamo> listaauxiliar = new List<Prestamo>();
            int i = 0;
            
            while(i < listaprestamos.Count)
            {
                if(listaprestamos[i].Cliente.CodigoSocio == codigo)
                {
                    listaauxiliar.Add(listaprestamos[i]);
                }
                i++;
            }
            return listaauxiliar;
        }

        public List<Reserva> Reservaxclientes(int codigo)
        {
            List<Reserva> listaauxiliar = new List<Reserva>();
            int i = 0;

            while (i < listareservas.Count)
            {
                if (listareservas[i].Cliente.CodigoSocio == codigo)
                {
                    listaauxiliar.Add(listareservas[i]);
                }
                i++;
            }
            return listaauxiliar;

        }

        public List<Reserva> ReservaxLibro(int isbn, int ejemplar)
        {
            List<Reserva> listaauxiliar = new List<Reserva>();
            int i = 0;

            while (i < listareservas.Count)
            {
                if (listareservas[i].Libro.Isbn == isbn && listareservas[i].Libro.Ejemplar == ejemplar)
                {
                    listaauxiliar.Add(listareservas[i]);
                }
                i++;
            }
            return listaauxiliar;

        }

        public bool Prestarlibro(Libro lib)
        {
            Libro libro = this.buscarLibro(lib.Isbn, lib.Ejemplar);

            if (libro != null)
            {
                string estado = "Prestado";
                libro.Estado = estado;
                Datos.modificarLibroBD(estado,libro.Isbn,libro.Ejemplar);
                return true;
            }
            else
                return false;
        }

        public bool reservarlibro(Libro lib)
        {
            Libro libro = this.buscarLibro(lib.Isbn, lib.Ejemplar);

            if (libro != null)
            {
                string estado = "Reservado";
                libro.Estado = estado;
                Datos.modificarLibroBD(estado, libro.Isbn, libro.Ejemplar);
                return true;
            }
            else
                return false;
        }

        public bool estadodecliente(int codigo)
        {
            int i = 0;
            int contador = 0;
            DateTime fechahoy = DateTime.Now;//aqui se modifica si se desea comprobar con fechas inventadas
            //DateTime fechahoy;
            while (i < listaprestamos.Count)
            {
                //fechahoy = listaprestamos[i].FechaReserva.AddDays(6);
                if (listaprestamos[i].Cliente.CodigoSocio == codigo && listaprestamos[i].estadoVencimiento(fechahoy))
                    contador++;
                i++;
            }
            if (contador == 0)
                return true;
            else
                return false;

        }

        public Reserva buscarReservaEspecifica(int codigocli, int isbn, int ejemplar)
        {
            int i = 0;
            List<Reserva> reservas = this.Reservaxclientes(codigocli);
            Reserva res;

            while (i < reservas.Count && !(reservas[i].Libro.Isbn == isbn && reservas[i].Libro.Ejemplar == ejemplar))
                i++;
            if (i == reservas.Count)
                return null;
            else
                return reservas[i];
            
        }

        public bool ahireserva(int isbn, int ejemplar)
        {
            List<Reserva> aux = this.ReservaxLibro(isbn, ejemplar);

            if (aux == null)
                return true;
            else
                return false;
        }


        public Prestamo buscarPrestamoEspecifica(int codigocliente, int isbn, int ejemplar)
        {
            int i = 0;
            List<Prestamo> prestamos = this.prestamosxclientes(codigocliente);
            Prestamo pres;


            while (i < prestamos.Count && !(prestamos[i].Libro.Isbn == isbn && prestamos[i].Libro.Ejemplar == ejemplar))
                i++;

            if (i == prestamos.Count)
                pres = null;
            else
                pres = prestamos[i];

            return pres;
       }

        public Prestamo buscarPrestamoEspecifica(int isbn, int ejemplar)//solo va a haber uno con el mismo libro y ejemplar
        {
            int i = 0;
            while (i < listaprestamos.Count && !(listaprestamos[i].Libro.Isbn == isbn && listaprestamos[i].Libro.Ejemplar == ejemplar))
                i++;

            if (i == listaprestamos.Count)
                return null;
            else
                return listaprestamos[i];
            
        }

        public bool devolucionLibro(Libro libro)
        {
            Libro lib = this.buscarLibro(libro.Isbn, libro.Ejemplar);

            if (lib != null)
            {
                string estado;
                List<Reserva> reservas = this.ReservaxLibro(lib.Isbn, lib.Ejemplar);
                if (reservas != null)
                    estado = "Reservado";
                else
                    estado = "Disponible";
                libro.Estado = estado;
                Datos.modificarLibroBD(estado, libro.Isbn, libro.Ejemplar);
                return true;
            }
            else
                return false;
        }



        public DateTime fechaDeReserva(Cliente cli, Libro lib)
        {
            
            DateTime fechaDispo = DateTime.Now;
            int i = 0;
            List<Reserva> reservasaux = this.ReservaxLibro(lib.Isbn,lib.Ejemplar);

            if (reservasaux != null)
            {
                DateTime fecha = DateTime.Now;
                while (i < reservasaux.Count)
                {
                    if (fecha < reservasaux[i].FechaDisponibilidad)
                        fecha = reservasaux[i].FechaDisponibilidad;
                    i++;
                }
                
                fechaDispo = fecha.AddDays(cli.dardiasXretirar());
            }
            else
            {
                Prestamo pres = this.buscarPrestamoEspecifica(lib.Isbn, lib.Ejemplar);
                if (pres != null)
                    fechaDispo = pres.Fechadevolucion;
            }
            return fechaDispo;
        }

        public bool modificarReserva(Reserva reserva, DateTime fecha)
        {
            Reserva rese = this.buscarreserva(reserva.Codigo);
            if (rese == null)
                return false;
            else
            {
                rese.FechaDisponibilidad = fecha;
                return true;
            }
              
        }

        public bool ahireserva(int codigoreserva)
        {
            int i = 0;
            while (i < listareservas.Count && listareservas[i].Codigo != codigoreserva)
                i++;
            if (i == listareservas.Count)
                return false;
            else
                return true;
        }

        public bool renovarPrestamo(Prestamo pres)
        {
            
            Prestamo prestamo = this.buscarPrestamoEspecifica(pres.Cliente.CodigoSocio, pres.Libro.Isbn, pres.Libro.Ejemplar);
            if(prestamo != null)
            {
                DateTime fecha = prestamo.Fechadevolucion.AddDays(prestamo.Cliente.dardiasXretirar());
                prestamo.Fechadevolucion = fecha;
                Datos.modificarPrestamoBD(pres.Codigo, fecha);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool soselproximo(Reserva reserva, DateTime fecha)
        {

                if (fecha <= reserva.FechaDisponibilidad)
                    return true;
                else
                    return false;
            
        }

        public void limpiarReservasVencidas()
        {
            List<Reserva> reservasauxliar = new List<Reserva>();
            int i = 0;
            DateTime hoy = DateTime.Now;
            while(i < listareservas.Count)
            {
                if (listareservas[i].FechaDisponibilidad >= hoy)
                    reservasauxliar.Add(listareservas[i]);
                i++;
            }

            listareservas = reservasauxliar;
        }

        public List<Cliente> clientesPendientes()
        {
            int i = 0;
            int o = 0;
            List<Cliente> clientesaux = new List<Cliente>();
            DateTime hoy = DateTime.Now;

            while(i < listaprestamos.Count)
            {
                if (listaprestamos[i].Fechadevolucion < hoy)
                {
                    while (o < clientesaux.Count && clientesaux[o].CodigoSocio != listaprestamos[i].Cliente.CodigoSocio)
                        o++;
                    if(o == clientesaux.Count)
                        clientesaux.Add(listaprestamos[i].Cliente);
                    o = 0;
                }
                i++;
            }
            return clientesaux;
        }

        public bool limiteDePrestamos(int codigocli)
        {
            int i = 0;
            int contador = 0;
            while(i < listaprestamos.Count)
            {
                if (listaprestamos[i].Cliente.CodigoSocio == codigocli)
                    contador++;
                i++;
            }
            if (contador <= 3)
                return true;
            else
                return false;
        }

        public int cantidadPrestamosFaltantes(int codigocli)
        {
            int i = 0;
            int contador = 0;
            while (i < listaprestamos.Count)
            {
                if (listaprestamos[i].Cliente.CodigoSocio == codigocli)
                    contador++;
                i++;
            }
            return 3 - contador;
        }

      
        public Prestamo darPrestamo(int index)
        {
            return listaprestamos[index];
        }

        public Reserva darReserva(int index)
        {
            return listareservas[index];
        }

        public Libro darLibro(int index)
        {
            return listalibros[index];
        }

        // METODOS DE LA BD

        //public void ponerPath(string ruta)
        //{
        //    Datos.setRutaExe(ruta);
        //}
        public List<Libro> FiltroIsbn(int isbn)
        {
            List<Libro> libros = new List<Libro>();
            int i = 0;
            while(i<listalibros.Count)
            {
                if (listalibros[i].Isbn == isbn)
                    libros.Add(listalibros[i]);
                i++;
            }
            return libros;
           
        }

        

        public List<Libro> Filtroeditorial(string editorial)
        {
            List<Libro> libros = new List<Libro>();
            int i = 0;
            while (i < listalibros.Count)
            {
                if (listalibros[i].Editorial == editorial)
                    libros.Add(listalibros[i]);
                i++;
            }
            return libros;

        }

        public List<Libro> Filtroautor(string autor)
        {
            List<Libro> libros = new List<Libro>();
            int i = 0;
            while (i < listalibros.Count)
            {
                if (listalibros[i].Autor == autor)
                    libros.Add(listalibros[i]);
                i++;
            }
            return libros;

        }

        public List<Libro> Filtrogenero(string genero)
        {
            List<Libro> libros = new List<Libro>();
            int i = 0;
            while (i < listalibros.Count)
            {
                if (listalibros[i].Genero == genero)
                    libros.Add(listalibros[i]);
                i++;
            }
            return libros;

        }

        public void limpiarReservasxLibro(int isbn, int ejemplar)
        {
            //List<Reserva> lista = new List<Reserva>();
           
            int i = 0;
            while(i < listareservas.Count)
            {
                if (listareservas[i].Libro.Isbn == isbn && listareservas[i].Libro.Ejemplar == ejemplar)
                {
                    eliminarReserva(listareservas[i].Codigo);
                    
                }
                i++;
            }
            
        }
        public void limpiarReservasxLibro(int isbn)
        {
            //List<Reserva> lista = new List<Reserva>();
           
            int i = 0;
            while (i < listareservas.Count)
            {
                if (listareservas[i].Libro.Isbn == isbn)
                {
                    eliminarReserva(listareservas[i].Codigo);
                   
                }
                i++;
            }
           
        }

        public void limpiarPrestamoxLibro(int isbn, int ejemplar)
        {
            
            int i = 0;
            while(i<listaprestamos.Count)
            {
                if (listaprestamos[i].Libro.Isbn == isbn && listaprestamos[i].Libro.Ejemplar == ejemplar)
                {
                    eliminarPrestamo(listaprestamos[i].Codigo);
                    
                }
                i++;
            }
            
        }
        public void limpiarPrestamoxLibro(int isbn)
        {
           
            int i = 0;
            while (i < listaprestamos.Count)
            {
                if (listaprestamos[i].Libro.Isbn == isbn)
                {
                    eliminarPrestamo(listaprestamos[i].Codigo);
                    
                }
                i++;
            }
            
        }
        public void limpiarPrestamoxCliente(int codigo)
        {
            int i = 0;
            while(i<listaprestamos.Count)
            {
                if(listaprestamos[i].Cliente.CodigoSocio == codigo)
                {
                    eliminarPrestamo(listaprestamos[i].Codigo);
                }
                i++;
            }
        }
        public void limpiarReservaxCliente(int codigo)
        {
            int i = 0;
            while(i<listareservas.Count)
            {
                if(listareservas[i].Cliente.CodigoSocio == codigo)
                {
                    eliminarReserva(listareservas[i].Codigo);
                }
                i++;
            }
        }

        public void cargarDatosDesdeBD()
        {

            Datos dato = new Datos();
            ArrayList a = new ArrayList();

            int i = 0;



            //CARGA CLIENTE
            a = dato.RecuperaCliente();
            Cliente c = null;

            for (i = 0; i < a.Count; i++)
            {
                if ((bool)((ArrayList)a[i])[5])
                {
                    c = new ClienteEspecial();
                    c.armarObjeto((ArrayList)a[i]);
                    listaclientes.Add(c);
                }
                else
                {
                    c = new ClienteComun();
                    c.armarObjeto((ArrayList)a[i]);
                    listaclientes.Add(c);

                }
            }

            //CARGAR LIBRO
            a = dato.RecuperarLibro();
            Libro l = null;

            for (i = 0; i < a.Count; i++)
            {
                l = new Libro();
                l.armarObjeto((ArrayList)a[i]);
                listalibros.Add(l);
               
            }

            //CARGAR PRESTAMO

            a = dato.RecuperarPrestamo();
            Prestamo pres = null;
            

            for(i = 0; i < a.Count; i++)
            {
                int cod = (int)((ArrayList)a[i])[0];
                int codcliente = (int)((ArrayList)a[i])[1];
                int isbn = (int)((ArrayList)a[i])[2];
                int ejemplar = (int)((ArrayList)a[i])[3];
                DateTime fecha = (DateTime)((ArrayList)a[i])[4];
                DateTime fechadev = (DateTime)((ArrayList)a[i])[5];
                c = buscarCliente(codcliente);
                l = buscarLibro(isbn, ejemplar);

                if(c != null && l != null)
                {
                    pres = new Prestamo();
                    pres.armarObjeto(cod, c, l, fecha, fechadev);
                    listaprestamos.Add(pres);
                }
            }

            //CARGAR RESERVA

            a = dato.RecuperarReserva();
            Reserva res= null;


            for (i = 0; i < a.Count; i++)
            {
                int cod = (int)((ArrayList)a[i])[0];
                int codcliente = (int)((ArrayList)a[i])[1];
                int isbn = (int)((ArrayList)a[i])[2];
                int ejemplar = (int)((ArrayList)a[i])[3];
                DateTime fecha = (DateTime)((ArrayList)a[i])[4];

                c = buscarCliente(codcliente);
                l = buscarLibro(isbn, ejemplar);

                if (c != null && l != null)
                {
                    res = new Reserva();
                    res.armarObjeto(cod, c, l, fecha);
                    listareservas.Add(res);
                }
            }


        }
    }
}
