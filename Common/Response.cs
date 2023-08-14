using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Response
    {

        public string Message { get; set; }
        public object ResponseObject { get; set; }
        public bool IsSuccessful { get; set; }


    }
}
