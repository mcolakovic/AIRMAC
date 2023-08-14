using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.Exceptions
{
    public class SQLOperationException : Exception
    {
        public SQLOperationException()
        {
        }
        public SQLOperationException(string message) : base(message)
        {
        }
    }
}
