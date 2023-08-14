using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class RezultatInspekcijeSO : SystemOperationBase
    {
        private readonly RotablePartsService rotablePartsService;
        private static Object _lock = new Object();
        public RezultatInspekcijeSO(RotablePartsService rotablePartsService)
        {
            this.rotablePartsService = rotablePartsService;
        }
        public bool Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                lock (_lock)
                {
                    repository.Update(rotablePartsService);
                }
                Result = true;
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da prebaci dio u magacin servisiranih avionskih dijelova!");
            }

        }
    }
}
