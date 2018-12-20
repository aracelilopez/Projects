using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaDeNegocio
{
    public class Prestamo
    {
        private int codigo;
        private Cliente cliente;
        private Libro libro;
        private DateTime fechareserva;
        private DateTime fechadevolucion;

        public Prestamo()
        {
            codigo = 0;
            cliente = null;
            libro = null;
            fechareserva = DateTime.Now;
            fechadevolucion = DateTime.Now;
        }

        public Prestamo(int cod, Cliente cli, Libro li, DateTime reser, DateTime devo)
        {
            codigo = cod;
            cliente = cli;
            libro = li;
            fechareserva = reser;
            fechadevolucion = devo;
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }

        public Libro Libro
        {
            get
            {
                return libro;
            }
            set
            {
                libro = value;
            }
        }

        public DateTime FechaReserva
        {
            get
            {
                return fechareserva;
            }
            set
            {
                fechareserva = value;
            }
        }

        public DateTime Fechadevolucion
        {
            get
            {
                return fechadevolucion;
            }
            set
            {
                fechadevolucion = value;
            }
        }
        //metodos

        public bool estadoVencimiento(DateTime fechahoy)
        {
            return fechahoy > fechadevolucion;
        }

        //base de datos
        public ArrayList desarmarObjeto()
        {
            ArrayList datos = new ArrayList();
            datos.Add(codigo);
            datos.Add(cliente.CodigoSocio);
            datos.Add(libro.Isbn);
            datos.Add(libro.Ejemplar);
            datos.Add(fechareserva);
            datos.Add(fechadevolucion);
           
            return datos;
        }

        public void armarObjeto(int cod, Cliente cli, Libro lib, DateTime reser, DateTime devolu)
        {
            codigo = cod;
            cliente = cli;
            libro = lib;
            fechareserva = reser;
            fechadevolucion = devolu;
        }

        public override string ToString()
        {
            return codigo + " - Cliente: " + cliente.CodigoSocio + " - libro: " + libro.Isbn + " - ejemplar: " + libro.Ejemplar;
        }

    }
}
