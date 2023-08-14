using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class UcitajListuAvionaSO : SystemOperationBase
    {
        private readonly Aircraft aircraft;
        public UcitajListuAvionaSO(Aircraft aircraft)
        {
            this.aircraft = aircraft;
        }
        public List<Aircraft> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.SearchAll(aircraft).OfType<Aircraft>().ToList();
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da pronađe podatke o avionu i aerodromima!");
            }
            
        }
    }
}

