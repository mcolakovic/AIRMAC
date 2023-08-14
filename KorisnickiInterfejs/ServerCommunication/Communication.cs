using Common;
using KorisnickiInterfejs.Exceptions;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace KorisnickiInterfejs.ServerCommunication
{
    class Communication
    {
        private static Communication instance;
        private CommunicationHelper helper;
        private Socket socket;

        private Communication()
        {
        }

        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }

        public void Connect()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                helper = new CommunicationHelper(socket);
            }
        }

        public T SendRequest<T>(Request request) where T : class
        {
            try
            {
                helper.Send(request);
                Response response = helper.Receive<Response>();
                if (response.IsSuccessful)
                {
                    return (T)response.ResponseObject;
                }

                else
                {
                    throw new SystemOperationException(response.Message);
                }
            }
            catch (IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }

        public T SendRequest<T>(Operation operation, object requestObject = null) where T : class
        {
            try
            {
                Request request = new Request(operation, requestObject);
                helper.Send(request);
                Response response = helper.Receive<Response>();
                if (response.IsSuccessful)
                {
                    return (T)response.ResponseObject;
                }
                else
                {
                    throw new SystemOperationException(response.Message);
                }
            }
            catch (IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }

        public void CloseConnestion()
        {
            try
            {
                Request request = new Request(Operation.EndConnection);
                helper.Send(request);
                socket.Shutdown(SocketShutdown.Both);
                socket.Dispose();
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

    }
}
