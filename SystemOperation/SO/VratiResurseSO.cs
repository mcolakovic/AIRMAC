using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class VratiResurseSO : SystemOperationBase
    {
        private readonly ResourceAvailability resourceAvailability;
        public VratiResurseSO(ResourceAvailability resourceAvailability)
        {
            this.resourceAvailability = resourceAvailability;
        }
        public List<ResourceAvailability> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.SearchAll(resourceAvailability).OfType<ResourceAvailability>().ToList();
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da pronađe podatke o preostalim resursima");
            }
        }
    }
}
