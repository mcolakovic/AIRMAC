using ObrerverPatern.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrerverPatern.Objects
{
    [Serializable]
    public class ServerObject : MarshalByRefObject, ISubject
    {
        private static ArrayList clients = new ArrayList();
        public void Attach(IObserver client)
        {
            clients.Add(client);
        }

        public void Detach(IObserver client)
        {
            clients.Remove(client);
        }

        public static void Notify()
        {
            for (int i = 0; i < clients.Count; i++)
            {
                try
                {
                    ((IObserver)clients[i]).Update();
                }
                catch
                {
                    Debug.WriteLine("Client disconected!");
                }
            }
                
                
        }
    }
}
