using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones
{
    public class BlancoException: Exception
    {
        public BlancoException()
            : base("alguna cadena en blanco")
        {

        }
    }
}
