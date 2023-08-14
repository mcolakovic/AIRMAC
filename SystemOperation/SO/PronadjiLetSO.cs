using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class PronadjiLetSO : SystemOperationBase
    {
        private readonly LogBook logbook;

        public PronadjiLetSO(LogBook logbook)
        {
            this.logbook = logbook;
        }
        public LogBook Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = (LogBook)repository.SearchOne(logbook);
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da nađe podatke o konkretnom letu!");
            }
        }
    }
}
