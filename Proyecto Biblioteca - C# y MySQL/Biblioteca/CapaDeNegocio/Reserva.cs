using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaDeNegocio
{
    public class Reserva
    {
        private int codigo;
        private Cliente cliente;
        private Libro libro;
        private DateTime fechaDisponibilidad;

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

        public DateTime FechaDisponibilidad
        {
            get
            {
                return fechaDisponibilidad;
            }
            set
            {
                fechaDisponibilidad = value;
            }
        }

        public Reserva(int cod, Cliente cli, Libro lib, DateTime fecha)
        {
            codigo = cod;
            cliente = cli;
            libro = lib;
            fechaDisponibilidad = fecha;
        }

        public Reserva()
        {
            codigo = 0;
            cliente = null;
            libro = null;
            fechaDisponibilidad = DateTime.Now;
        }

        //base de datos
        public ArrayList desarmarObjeto()
        {
            ArrayList datos = new ArrayList();
            datos.Add(codigo);
            datos.Add(cliente.CodigoSocio);
            datos.Add(libro.Isbn);
            datos.Add(libro.Ejemplar);
            datos.Add(fechaDisponibilidad);

            return datos;
        }


        public void armarObjeto(int cod, Cliente cli, Libro lib, DateTime fecha)
        {
            codigo = cod;
            cliente = cli;
            libro = lib;
            fechaDisponibilidad = fecha;
        }

        public override string ToString()
        {
            return codigo + " - Cliente: " + cliente.CodigoSocio + " - libro: " + libro.Isbn + " - ejemplar: " + libro.Ejemplar + ", estara disponible: " + fechaDisponibilidad;
        }

    }
}
