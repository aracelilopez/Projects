using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaDeNegocio
{
    public class ClienteComun: Cliente
    {
        public ClienteComun(int cod, int d, string nom, string ape, string loc): 
            base(cod, d, nom, ape, loc)
        {

        }

        public ClienteComun()
            : base()
        {

        }

        public override int dardiasXretirar()
        {
            return 3;
        }

        public override void armarObjeto(ArrayList datos)
        {
            codigoSocio = int.Parse(datos[0].ToString());
            dni = int.Parse(datos[1].ToString());
            nombre = datos[2].ToString();
            apellido = datos[3].ToString();
            localidad = datos[4].ToString();
        }

        public override string ToString()
        {
            return codigoSocio + " - " + nombre + " - " + apellido + " - ES COMÚN " ;
        }
    }
}
