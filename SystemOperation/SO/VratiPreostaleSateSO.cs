using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class VratiPreostaleSateSO : SystemOperationBase
    {
       


        private readonly RemainingHours remainingHours;
        public VratiPreostaleSateSO(RemainingHours remainingHours)
        {
            this.remainingHours = remainingHours;
        }
        public List<RemainingHours> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.SearchAll(remainingHours).OfType<RemainingHours>().ToList();
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da pronađe podatke o preostalim resursima");
            }
        }


    }
}
