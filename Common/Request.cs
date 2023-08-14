using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Request
    {
        public Operation Operation { get; set; }
        public object RequestObject { get; set; }
        

        public Request(Operation operation)
        {
            this.Operation = operation;

        }
        public Request(Operation operation, object requestObject)
        {
            this.Operation = operation;
            this.RequestObject = requestObject;

        }
    }
}
