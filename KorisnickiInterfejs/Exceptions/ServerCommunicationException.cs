using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.Exceptions
{
    public class ServerCommunicationException : Exception
    {
        public ServerCommunicationException()
        {
        }

        public ServerCommunicationException(string message) : base(message)
        {
        }
    }
}
