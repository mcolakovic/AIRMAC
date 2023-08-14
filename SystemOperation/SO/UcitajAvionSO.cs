using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class UcitajAvionSO : SystemOperationBase
    {
        private readonly Aircraft aircraft;
        public UcitajAvionSO(Aircraft aircraft)
        {
            this.aircraft = aircraft;
        }
        public Aircraft Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = (Aircraft)repository.SearchOne(aircraft);
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da pronađe podatke o avionu!");
            }
            
        }
    }
}
