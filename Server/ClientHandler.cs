using ApplicationLogic;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private readonly List<ClientHandler> clients;
        private CommunicationHelper helper;
        public event EventHandler OdjavljenKlijent;
        public event EventHandler PrijavljenKlijent;
        private User user;
        public User User { get => user; }

        public ClientHandler(Socket socket, List<ClientHandler> clients)
        {
            this.socket = socket;
            this.clients = clients;
            helper = new CommunicationHelper(socket);
        }

        internal void HandleRequests()
        {
            try
            {
                Request request;
                while ((request = helper.Receive<Request>()).Operation != Operation.EndConnection)
                {
                    Response response;
                    try
                    {
                        response = CreateResponse(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response();
                        response.Message = ex.Message;
                        response.IsSuccessful = false;

                    }
                    helper.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                Stop();
                OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
            }
        }

        private Response CreateResponse(Request request)
        {
            Response response = new Response();
            switch (request.Operation)
            {
                case Operation.GetAircrafts:
                    response.ResponseObject = Controller.Instance.UcitajListuAviona((Aircraft)request.RequestObject);
                    if (response.ResponseObject != null)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe podatke o avionima!";
                    }
                    break;
                case Operation.GetAircraft:
                    response.ResponseObject = Controller.Instance.UcitajAvion((Aircraft)request.RequestObject);
                    if (response.ResponseObject != null)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe podatke o avionu!";
                    }
                    break;
                case Operation.GetAirports:
                    response.ResponseObject = Controller.Instance.UcitajListuAerodroma((Airport)request.RequestObject);
                    if (((List<Airport>)response.ResponseObject).Count > 0)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe podatke o aerodromima!";
                    }
                    break;
                case Operation.AddLogBook:
                    response.ResponseObject = Controller.Instance.ZapamtiLet((LogBook)request.RequestObject);
                    response.IsSuccessful = true;
                    break;
                case Operation.AddUser:
                    response.ResponseObject = Controller.Instance.ZapamtiRegistraciju((User)request.RequestObject);
                    response.IsSuccessful = true;
                    break;
                case Operation.AddAircraft:
                    response.ResponseObject = Controller.Instance.DodajAvion((Aircraft)request.RequestObject);
                    response.IsSuccessful = true;
                    break;
                case Operation.GetLogBook:
                    response.ResponseObject = Controller.Instance.UcitajListuLetova((LogBook)request.RequestObject);
                    if (((List<LogBook>)response.ResponseObject).Count  > 0)
                    {
                       response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe podatke o realizovanim letovima!";
                    }
                    break;
                case Operation.GetFlight:
                    response.ResponseObject = Controller.Instance.PronadjiLet((LogBook)request.RequestObject);
                    if (response.ResponseObject != null)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe podatke o realizovanim letu!";
                    }
                    break;
                case Operation.UpdateLogBook:
                    Controller.Instance.AzurirajLet((LogBook)request.RequestObject);
                    response.ResponseObject = request.RequestObject;
                    response.IsSuccessful = true;
                    break;
                case Operation.SearchRotableParts:
                    response.ResponseObject = Controller.Instance.NadjiKarton((RotableParts)request.RequestObject);
                    if (response.ResponseObject != null)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da nađe karton dijela u evidenciji avio dijelova!";
                    }
                    break;
                case Operation.AddRotableParts:
                    response.ResponseObject  = Controller.Instance.ZapamtiKarton((RotablePartsLog)request.RequestObject);
                    response.IsSuccessful = true;
                    break;
                case Operation.SearchRotablePartsStock:
                    response.ResponseObject = Controller.Instance.NadjiDioMagacin((RotablePartsLog)request.RequestObject);
                    if (response.ResponseObject != null)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe avionski dio u magacinu avionskih dijelova!";
                    }
                    break;
                case Operation.UpdateRotableParts:
                    Controller.Instance.AzurirajKarton((RotablePartsLog)request.RequestObject);
                    response.ResponseObject = request.RequestObject;
                    response.IsSuccessful = true;
                    break;
                case Operation.InstallToAircraft:
                    response.ResponseObject = Controller.Instance.DodajDioNaAvion((RotablePartsLog)request.RequestObject);
                    response.IsSuccessful = true;
                    break;
                case Operation.SearchResourceAvailability:
                    response.ResponseObject = Controller.Instance.VratiResurse((ResourceAvailability)request.RequestObject);
                    if (((List<ResourceAvailability>)response.ResponseObject).Count > 0)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe podatke o preostalim resursima!";
                    }
                    break;
                case Operation.SearchRotablePartsAircraft:
                    response.ResponseObject = Controller.Instance.NadjiDioAvion((RotablePartsLog)request.RequestObject);
                    if (response.ResponseObject != null)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe podatke o instaliranom dijelu!";
                    }
                    break;
                case Operation.SearchRemainingHours:
                    response.ResponseObject = Controller.Instance.VratiPreostaleSate((RemainingHours)request.RequestObject);
                    if (response.ResponseObject != null)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe podatke o instaliranom dijelu!";
                    }
                    break;
                case Operation.SearchRotablePartHistory:
                    response.ResponseObject = Controller.Instance.VratiIstorijuDijela((RotablePartHistory)request.RequestObject);
                    if (response.ResponseObject != null)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe podatke o instaliranom dijelu!";
                    }
                    break;
                case Operation.SearchRemainingCycles:
                    response.ResponseObject = Controller.Instance.VratiPreostaleCikluse((RemainingCycles)request.RequestObject);
                    if (response.ResponseObject != null)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe podatke o instaliranom dijelu!";
                    }
                    break;
                case Operation.SearchRemainingDays:
                    response.ResponseObject = Controller.Instance.VratiPreostaleDane((RemainingDays)request.RequestObject);
                    if (response.ResponseObject != null)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe podatke o instaliranom dijelu!";
                    }
                    break;
                case Operation.SendFromAircraftToStock:
                    response.ResponseObject = Controller.Instance.PrebaciDioSaAvionaUMagacin((RotablePartsLog)request.RequestObject);
                    response.IsSuccessful = true;
                    break;
                case Operation.SendToService:
                    response.ResponseObject = Controller.Instance.PrebaciDioIzMagacinaUServis((RotablePartsLog)request.RequestObject);
                    response.IsSuccessful = true;
                    break;
                case Operation.SearchRotablePartsService:
                    response.ResponseObject = Controller.Instance.NeservisiraniDio((RotablePartsLog)request.RequestObject);
                    if (response.ResponseObject != null)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe neservisirane dio aviona!";
                    }
                    break;
                case Operation.SearchUnservicable:
                    response.ResponseObject = Controller.Instance.NadjiNeservisirane((UnserviceableParts)request.RequestObject);
                    if (((List<UnserviceableParts>)response.ResponseObject).Count > 0)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe neservisirane dijelove aviona!";
                    }
                    break;
                case Operation.ServiceInspection:
                    Controller.Instance.RezultatInspekcije((RotablePartsService)request.RequestObject);
                    response.ResponseObject = request.RequestObject;
                    response.IsSuccessful = true;
                    break;
                case Operation.SearchServiceable:
                    response.ResponseObject = Controller.Instance.NadjiServisirane((ServiceableParts)request.RequestObject);
                    if (((List<ServiceableParts>)response.ResponseObject).Count > 0)
                    {
                        response.IsSuccessful = true;
                    }
                    else
                    {
                        response.IsSuccessful = false;
                        response.Message = "Sistem ne može da pronađe servisirane dijelove aviona!";
                    }
                    break;
                case Operation.SendFromServiceToStock:
                    response.ResponseObject = Controller.Instance.PrebaciDioIzServisaUMagacin((RotablePartsLog)request.RequestObject);
                    response.IsSuccessful = true;
                    break;
                case Operation.Login:
                    bool exist = false;
                    foreach (ClientHandler c in clients)
                    {
                        if (c.User != null)
                        {
                            if (c.User.Username == ((User)request.RequestObject).Username)
                            {
                                exist = true;
                                break;
                            }
                        }
                    }
                    if (exist)
                    {
                        response.ResponseObject = null;
                        response.IsSuccessful = false;
                        response.Message = "Korisnicko ime je zauzeto";
                    }
                    else
                    {
                        User user = (User)Controller.Instance.VerifikacijaKorisnika((User)request.RequestObject);
                        if (user != null)
                        {
                            response.ResponseObject = request.RequestObject;
                            this.user = user;
                            this.User.IPAddress = socket.RemoteEndPoint.ToString();
                            this.User.LogTime = DateTime.Now.ToString();
                            response.IsSuccessful = true;
                            PrijavljenKlijent?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            response.ResponseObject = null;
                            response.IsSuccessful = false;
                            response.Message = "Pogrešni kredencijali";
                        }
                    }
                   break;
            }
            return response;
        }

        internal void Stop()
        {
            try
            {
                if (socket != null)
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Dispose();
                    socket = null;
                }
                OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            

        }
    }
}
