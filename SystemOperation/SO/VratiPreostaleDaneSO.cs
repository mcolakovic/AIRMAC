using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class VratiPreostaleDaneSO : SystemOperationBase
    {



        private readonly RemainingDays remainingDays;
        public VratiPreostaleDaneSO(RemainingDays remainingDays)
        {
            this.remainingDays = remainingDays;
        }
        public List<RemainingDays> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.SearchAll(remainingDays).OfType<RemainingDays>().ToList();
            }
            catch (Exception)
            {
                throw new SystemOperationException("Sistem ne može da pronađe podatke o preostalim resursima");
            }
        }


    }
}
