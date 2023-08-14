using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class NadjiServisiraneSO : SystemOperationBase
    {
        private readonly ServiceableParts serviceableParts;
        public NadjiServisiraneSO(ServiceableParts servicableParts)
        {
            this.serviceableParts = servicableParts;
        }
        public List<ServiceableParts> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.SearchAll(serviceableParts).OfType<ServiceableParts>().ToList();
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da pronađe servisirane dijelove aviona!");
            }
        }
    }
}
