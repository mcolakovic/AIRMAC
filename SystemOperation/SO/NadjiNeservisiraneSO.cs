using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class NadjiNeservisiraneSO : SystemOperationBase
    {
        private readonly UnserviceableParts unservicableParts;
        public NadjiNeservisiraneSO(UnserviceableParts unservicableParts)
        {
            this.unservicableParts = unservicableParts;
        }
        public List<UnserviceableParts> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.SearchAll(unservicableParts).OfType<UnserviceableParts>().ToList();
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da pronađe neservisirane dijelove aviona!");
            }
        }
    }
}
