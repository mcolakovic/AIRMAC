using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class ZapamtiKartonSO : SystemOperationBase
    {
        private RotablePartsLog rotablePartsLog;
        private static Object _lock = new Object();
        public ZapamtiKartonSO(RotablePartsLog rotablePartsLog)
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
                    rotablePartsLog.RotableParts.ID_RotableParts = repository.Add(rotablePartsLog.RotableParts);
                    ((RotablePartsStock)rotablePartsLog.RotablePartsSubClass).RotableParts.ID_RotableParts = rotablePartsLog.RotableParts.ID_RotableParts;
                    rotablePartsLog.ID_RotablePartsLog = repository.Add(rotablePartsLog);
                    ((RotablePartsStock)rotablePartsLog.RotablePartsSubClass).RotablePartsLog.ID_RotablePartsLog = rotablePartsLog.ID_RotablePartsLog;
                    repository.Add((RotablePartsStock)rotablePartsLog.RotablePartsSubClass);
                }
                Result = rotablePartsLog;
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da sačuva karton dijela u evidenciju avio dijelova!");
            }
        }
    }
}

            


