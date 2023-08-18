using ObserverPatern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatern.Objects
{
    [Serializable]
    public class ClientObject : MarshalByRefObject, IObserver
    {
        public event EventHandler ClientRefresh;
        public void Update()
        {
            ClientRefresh?.Invoke(this, EventArgs.Empty); 
        }
    }
}
