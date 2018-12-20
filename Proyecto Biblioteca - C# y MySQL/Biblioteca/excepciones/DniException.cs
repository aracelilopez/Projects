using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones
{
    public class DniException: Exception
    {
        public DniException()
            : base("los DNI possen 8 digitos")
        {

        }
    }
}
