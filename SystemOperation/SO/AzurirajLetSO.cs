using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO 
{
    public class AzurirajLetSO : SystemOperationBase
    {
        private readonly LogBook logbook;
        private static Object _lock = new Object();
        public AzurirajLetSO(LogBook logbook)
        {
            this.logbook = logbook;
        }
        public bool Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                lock (_lock)
                {
                    repository.Update(logbook);
                }
                
                Result = true;
            }
            catch (Exception ex )
            {
                throw new SystemOperationException("Sistem ne može da sačuva ažurirane podatke o realizovanom letu!");
            }

        }
    }
}
