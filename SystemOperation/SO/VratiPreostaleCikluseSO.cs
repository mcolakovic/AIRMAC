using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class VratiPreostaleCikluseSO : SystemOperationBase
    {



        private readonly RemainingCycles remainingCycles;
        public VratiPreostaleCikluseSO(RemainingCycles remainingCycles)
        {
            this.remainingCycles = remainingCycles;
        }
        public List<RemainingCycles> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.SearchAll(remainingCycles).OfType<RemainingCycles>().ToList();
            }
            catch (Exception)
            {
                throw new SystemOperationException("Sistem ne može da pronađe podatke o preostalim resursima");
            }
        }


    }
}
