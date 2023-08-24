using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using ObserverPatern.Objects;



namespace Server
{
    public class Server
    {
        private Socket serverSocket;
        private bool isRunning = false;
        private bool closedTCP = false;
        private List<ClientHandler> clients = new List<ClientHandler>();
        public List<ClientHandler> Clients { get => clients; }
        public event EventHandler ServerRefresh;
        TcpChannel chan;


        public void Start()
        {
            if (!isRunning)
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
                serverSocket.Listen(5);
                isRunning = true;
            }
        }

            public void Stop()
            {
                if (isRunning)
                {
                    serverSocket.Dispose();
                    serverSocket = null;
                    foreach (ClientHandler client in Clients.ToList())
                    {
                        client.Stop();
                    }
                    isRunning = false;
                }
            }

            public void HandleClients()
            {
                try
                {
                    while (true)
                    {
                        Socket clientSocket = serverSocket.Accept();
                        ClientHandler handler = new ClientHandler(clientSocket, Clients);
                        Clients.Add(handler);
                        handler.OdjavljenKlijent += Handler_OdjavljenKlijent;
                        handler.PrijavljenKlijent += Handler_PrijavljenKlijent;
                        Thread nitKlijenta = new Thread(handler.HandleRequests);
                        nitKlijenta.IsBackground = true;
                        nitKlijenta.Start();
                    }
                }
                catch (SocketException ex)
                {
                    Debug.WriteLine(">>>" + ex.Message);
                }
            }

        private void Handler_PrijavljenKlijent(object sender, EventArgs e)
        {
                ServerRefresh?.Invoke(sender, e);
        }

        private void Handler_OdjavljenKlijent(object sender, EventArgs e)
        {
                Clients.Remove((ClientHandler)sender);
                ServerRefresh?.Invoke(sender, e);
        }


        public void start_Subject()
        {
            if (isRunning && !closedTCP)
            {
                BinaryServerFormatterSinkProvider provider = new BinaryServerFormatterSinkProvider();
                provider.TypeFilterLevel = TypeFilterLevel.Full;
                IDictionary props = new Hashtable();
                props["port"] = 9000;

                chan = new TcpChannel(props, null, provider);
                ChannelServices.RegisterChannel(chan, true);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(ServerObject),
                   "Server", WellKnownObjectMode.Singleton);
                closedTCP = true;
            }
        }
        public void stop_Subject()
        {
            if(!isRunning && closedTCP)
            {
                ChannelServices.UnregisterChannel(chan);
                closedTCP = false;
            }
         }

    }
}
