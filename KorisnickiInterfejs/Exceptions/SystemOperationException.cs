using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.Exceptions
{
    public class SystemOperationException: Exception
    {
        public SystemOperationException()
        {
        }

        public SystemOperationException(string message) : base(message)
        {
        }
    }
}
