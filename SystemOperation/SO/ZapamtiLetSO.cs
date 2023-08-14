using Domain;
using System;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class ZapamtiLetSO : SystemOperationBase
    {
        private readonly LogBook logbook;
        private static Object _lock = new Object();
        public ZapamtiLetSO(LogBook logbook)
        {
            this.logbook = logbook;
        }
        public LogBook Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                lock (_lock)
                {
                    logbook.ID_LogBook = repository.Add(logbook);
                }    
                Result = logbook ;
            }
            catch (Exception)
            {
                throw new SystemOperationException("Sistem ne može da sačuva podatke o realizovanom letu!");
            }
            
        }
    }
}
