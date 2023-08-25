using Domain;
using System;
using System.Collections.Generic;
using SystemOperation;
using SystemOperation.SO;

namespace ApplicationLogic
{
    public class Controller
    {
        private static Controller instance;
        private Controller()
        {
        }
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }

   
        public List<Aircraft> UcitajListuAviona(Aircraft aircraft)
        {
            SystemOperationBase so = new UcitajListuAvionaSO(aircraft);
            so.ExecuteTemplate();
            return ((UcitajListuAvionaSO)so).Result;
        }

        public object UcitajAvion(Aircraft aircraft)
        {
            SystemOperationBase so = new UcitajAvionSO(aircraft);
            so.ExecuteTemplate();
            return ((UcitajAvionSO)so).Result;
        }

        public List<Airport> UcitajListuAerodroma(Airport airport)
        {
            SystemOperationBase so = new UcitajListuAerodromaSO(airport);
            so.ExecuteTemplate();
            return ((UcitajListuAerodromaSO)so).Result;
        }

        public object ZapamtiLet(LogBook logbook)
        {
            SystemOperationBase so = new ZapamtiLetSO(logbook);
            so.ExecuteTemplate();
            return ((ZapamtiLetSO)so).Result;
        }

        public object UcitajListuLetova(LogBook logbook)
        {
            SystemOperationBase so = new UcitajListuLetovaSO(logbook);
            so.ExecuteTemplate();
            return ((UcitajListuLetovaSO)so).Result;
        }

        public object PronadjiLet(LogBook logbook)
        {
            SystemOperationBase so = new PronadjiLetSO(logbook);
            so.ExecuteTemplate();
            return ((PronadjiLetSO)so).Result;
        }

        public bool AzurirajLet(LogBook logbook)
        {
            SystemOperationBase so = new AzurirajLetSO(logbook);
            so.ExecuteTemplate();
            return ((AzurirajLetSO)so).Result;
        }

        public object ZapamtiKarton(RotablePartsLog requestObject)
        {
            SystemOperationBase so = new ZapamtiKartonSO(requestObject);
            so.ExecuteTemplate();
            return ((ZapamtiKartonSO)so).Result;
        }

        public object NadjiKarton(RotableParts requestObject)
        {
            SystemOperationBase so = new NadjiKartonSO(requestObject);
            so.ExecuteTemplate();
            return ((NadjiKartonSO)so).Result;
        }

        public object NadjiDioMagacin(RotablePartsLog requestObject)
        {
            SystemOperationBase so = new NadjiDioMagacinSO(requestObject);
            so.ExecuteTemplate();
            return ((NadjiDioMagacinSO)so).Result;
        }

      
        public object DodajDioNaAvion(RotablePartsLog requestObject)
        {
            SystemOperationBase so = new DodajDioNaAvionSO(requestObject);
            so.ExecuteTemplate();
            return ((DodajDioNaAvionSO)so).Result;
        }

        public object NadjiDioAvion(RotablePartsLog requestObject)
        {
            SystemOperationBase so = new NadjiDioAvionSO(requestObject);
            so.ExecuteTemplate();
            return ((NadjiDioAvionSO)so).Result;
        }

        public object PrebaciDioSaAvionaUMagacin(RotablePartsLog requestObject)
        {
            SystemOperationBase so = new PrebaciDioSaAvionaUMagacinSO(requestObject);
            so.ExecuteTemplate();
            return ((PrebaciDioSaAvionaUMagacinSO)so).Result;
        }

       

        public object PrebaciDioIzMagacinaUServis(RotablePartsLog requestObject)
        {
            SystemOperationBase so = new PrebaciDioIzMagacinaUServisSO(requestObject);
            so.ExecuteTemplate();
            return ((PrebaciDioIzMagacinaUServisSO)so).Result;
        }

        public object NeservisiraniDio(RotablePartsLog requestObject)
        {
            SystemOperationBase so = new NeservisiraniDioSO(requestObject);
            so.ExecuteTemplate();
            return ((NeservisiraniDioSO)so).Result;
        }

        public object DodajAvion(Aircraft requestObject)
        {
            SystemOperationBase so = new DodajAvionSO(requestObject);
            so.ExecuteTemplate();
            return ((DodajAvionSO)so).Result;
        }

        public object ZapamtiRegistraciju(User requestObject)
        {
            SystemOperationBase so = new ZapamtiRegistracijuSO(requestObject);
            so.ExecuteTemplate();
            return ((ZapamtiRegistracijuSO)so).Result;
        }

        public object NadjiNeservisirane(UnserviceableParts requestObject)
        {
            SystemOperationBase so = new NadjiNeservisiraneSO(requestObject);
            so.ExecuteTemplate();
            return ((NadjiNeservisiraneSO)so).Result;
        }

        public bool RezultatInspekcije(RotablePartsService requestObject)
        {
            SystemOperationBase so = new RezultatInspekcijeSO(requestObject);
            so.ExecuteTemplate();
            return ((RezultatInspekcijeSO)so).Result;
        }

        public object NadjiServisirane(ServiceableParts requestObject)
        {
            SystemOperationBase so = new NadjiServisiraneSO(requestObject);
            so.ExecuteTemplate();
            return ((NadjiServisiraneSO)so).Result;
        }

        public object PrebaciDioIzServisaUMagacin(RotablePartsLog requestObject)
        {
            SystemOperationBase so = new PrebaciDioIzServisaUMagacinSO(requestObject);
            so.ExecuteTemplate();
            return ((PrebaciDioIzServisaUMagacinSO)so).Result;

        }

        public object VratiResurse(ResourceAvailability requestObject)
        {
            SystemOperationBase so = new VratiResurseSO(requestObject);
            so.ExecuteTemplate();
            return ((VratiResurseSO)so).Result;
        }

        public bool AzurirajKarton(RotablePartsLog requestObject)
        {
            SystemOperationBase so = new AzurirajKartonSO(requestObject);
            so.ExecuteTemplate();
            return ((AzurirajKartonSO)so).Result;
        }

        public object VerifikacijaKorisnika(User requestObject)
        {
            SystemOperationBase so = new VerifikacijaKorisnikaSO(requestObject);
            so.ExecuteTemplate();
            return ((VerifikacijaKorisnikaSO)so).Result;
        }

        public object VratiPreostaleSate(RemainingHours requestObject)
        {
            SystemOperationBase so = new VratiPreostaleSateSO(requestObject);
            so.ExecuteTemplate();
            return ((VratiPreostaleSateSO)so).Result;
        }

        public object VratiPreostaleCikluse(RemainingCycles requestObject)
        {
            SystemOperationBase so = new VratiPreostaleCikluseSO(requestObject);
            so.ExecuteTemplate();
            return ((VratiPreostaleCikluseSO)so).Result;
        }

        public object VratiPreostaleDane(RemainingDays requestObject)
        {
            SystemOperationBase so = new VratiPreostaleDaneSO(requestObject);
            so.ExecuteTemplate();
            return ((VratiPreostaleDaneSO)so).Result;
        }

        public object VratiIstorijuDijela(RotablePartHistory requestObject)
        {
            SystemOperationBase so = new VratiIstorijuDijelaSO(requestObject);
            so.ExecuteTemplate();
            return ((VratiIstorijuDijelaSO)so).Result;
        }
    }
}
