using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class DodajDioNaAvionSO : SystemOperationBase
    {
        private RotablePartsLog rotablePartsLog;
        private static Object _lock = new Object();
        public DodajDioNaAvionSO(RotablePartsLog rotablePartsLog)
        {
            this.rotablePartsLog = rotablePartsLog;
        }
        public RotablePartsLog Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                lock (_lock)
                {
                    rotablePartsLog.ID_RotablePartsLog = repository.Add(rotablePartsLog);
                    ((RotablePartsAircraft)rotablePartsLog.RotablePartsSubClass).RotablePartsLog.ID_RotablePartsLog = rotablePartsLog.ID_RotablePartsLog;
                    repository.Add((RotablePartsAircraft)rotablePartsLog.RotablePartsSubClass);
                }
                Result = rotablePartsLog;
            }
            catch (Exception)
            {
                throw new SystemOperationException("Sistem nije u mogućnosti da završi instalaciju avionskog dijela na avionu!");
            }
        }
    }
}




    