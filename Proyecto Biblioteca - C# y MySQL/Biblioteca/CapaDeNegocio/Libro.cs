using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaDeNegocio
{
    public class Libro
    {
        private int isbn;
        private int ejemplar;
        private string titulo;
        private string autor;
        private string editorial;
        private string genero;
        private string estado;// Disponible - Reservado - Pendiente

        //constructor
        public Libro(int i, int ej, String ti, string au,string edi, string ge, string esta)
        {
            isbn = i;
            ejemplar = ej;
            titulo = ti;
            autor = au;
            editorial = edi;
            genero = ge;
            estado = esta;
        }

        public Libro()
        {
            isbn = 0;
            ejemplar = 0;
            titulo = "";
            autor = "";
            editorial = "";
            genero = "";
            estado = "";
        }

        // getter y setter
        public int Isbn
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }
        public int Ejemplar
        {
            get
            {
                return ejemplar;
            }
            set
            {
                ejemplar = value;
            }
        }
        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }
        public string Editorial
        {
            get
            {
                return editorial;
            }
            set
            {
                editorial = value;
            }
        }
        public string Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }
        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
               estado = value;
            }
        }


        // METODO DE BD

        public ArrayList desarmarObjeto()
        {
            ArrayList datos = new ArrayList();
            datos.Add(isbn);
            datos.Add(ejemplar);
            datos.Add(titulo);
            datos.Add(autor);
            datos.Add(editorial);
            datos.Add(genero);
            datos.Add(estado);

            return datos;
        }

        public void armarObjeto(ArrayList datos)
        {
            isbn = int.Parse(datos[0].ToString());
            ejemplar = int.Parse(datos[1].ToString());
            titulo = datos[2].ToString();
            autor = datos[3].ToString();
            editorial = datos[4].ToString();
            genero = datos[5].ToString(); 
            estado = datos[6].ToString();
        }

        public override string ToString()
        {
            return isbn + " - " + ejemplar + " - " + titulo + " - " + autor + " - " + editorial +  " - " + genero + " - " + estado;
        }
    }
}
