using ObrerverPatern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrerverPatern.Objects
{
    [Serializable]
    public class ClientObject : MarshalByRefObject, IObserver
    {
        public event EventHandler ServerRefresh;
        public void Update()
        {
            ServerRefresh?.Invoke(this, EventArgs.Empty); 
        }
    }
}
