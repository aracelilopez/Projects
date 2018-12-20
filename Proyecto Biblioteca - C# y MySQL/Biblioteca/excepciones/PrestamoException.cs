using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones
{
    public class PrestamoException: Exception
    {
        public PrestamoException()
            : base("La proxima reserva de este libro no es de este cliente")
             {

             }
    }
}
