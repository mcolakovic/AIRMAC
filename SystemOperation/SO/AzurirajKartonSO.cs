using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class AzurirajKartonSO : SystemOperationBase
    {
        private readonly RotablePartsLog rotablePartsLog;
        private static Object _lock = new Object();
        public AzurirajKartonSO(RotablePartsLog rotablePartsLog)
        {
            this.rotablePartsLog = rotablePartsLog;
        }
        public bool Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                lock (_lock)
                {
                    repository.Update(rotablePartsLog.RotableParts);
                    repository.Update((RotablePartsStock)rotablePartsLog.RotablePartsSubClass);
                }
                Result = true;

            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da sačuva karton dijela u evidenciji avio dijelova!");
            }

        }
    }
}
