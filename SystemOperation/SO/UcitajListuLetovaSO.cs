using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class UcitajListuLetovaSO : SystemOperationBase
    {
        private readonly LogBook logbook;

        public UcitajListuLetovaSO(LogBook logbook)
        {
            this.logbook = logbook;
        }
        public List<LogBook> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.SearchAll(logbook).OfType<LogBook>().ToList();
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da pronađe podatke o realizovanim letovima!");
            }
        }
    }
}



