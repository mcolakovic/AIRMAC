using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class UcitajListuAerodromaSO : SystemOperationBase
    {
        private readonly Airport airport;
        public UcitajListuAerodromaSO(Airport airport)
        {
            this.airport = airport;
        }
        public List<Airport> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.SearchAll(airport).OfType<Airport>().ToList();
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da pronađe podatke o avionu i aerodromima!");
            }

           
        }
    }
}
