using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using excepciones;

namespace CapaDeNegocio
{
    public abstract class Cliente
    {
        protected int codigoSocio;
        protected int dni;
        protected string nombre;
        protected string apellido;
        protected string localidad;
        //protected List<Libro> libros;
       

        //constructor
        public Cliente(int cod, int d, string nom, string ape, string loc)
        {
            codigoSocio = cod;
            if (d < 10000000 || d > 99999999)
                throw new DniException();
            else
                 dni = d;
            nombre = nom;
            apellido = ape;
            localidad = loc;
            //libros = new List<Libro>();
        }

        public Cliente()
        {
            codigoSocio = 0;
            dni = 0;
            nombre = "";
            apellido = "";
            localidad = "";
            //libros = new List<Libro>();
        }

        //getter y setter
        public int CodigoSocio
        {
            get
            {
                return codigoSocio;
            }
            set
            {
                codigoSocio = value;
            }
        }
        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }
        public string Nombre
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
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public string Localidad
        {
            get
            {
                return localidad;
            }
            set
            {
                localidad = value;
            }
        }
        /*public List<Libro> Libros
        {
            get
            {
                return libros;
            }
            set
            {
                libros = value;
            }
        }*/
        

        public abstract int dardiasXretirar();

        //public abstract string ToString();
        
        public void modificar(int d, string n, string a, string loc)
        {
            dni = d;
            nombre = n;
            apellido = a;
            localidad = loc;
        }

        public bool sos(int d, int usu)
        {
            if (dni == d && usu == codigoSocio)
                return true;
            else
                return false;
        }

        // METODO DE LA BD

        public ArrayList desarmarObjeto()
        {
            ArrayList datos = new ArrayList();
            datos.Add(codigoSocio);
            datos.Add(dni);
            datos.Add(nombre);
            datos.Add(apellido);
            datos.Add(localidad);
            bool variable = false;
            if (this.dardiasXretirar() == 3)
            {
                variable = true;
                datos.Add(true);
            }
            else
            {
                variable = false;
                datos.Add(variable);
            }

            return datos;
        }

        public abstract void armarObjeto(ArrayList datos);


        
    }
}
