using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class NadjiDioMagacinSO : SystemOperationBase
    {
        private readonly RotablePartsLog rotablePartsLog;
        public NadjiDioMagacinSO(RotablePartsLog rotablePartsLog)
        {
            this.rotablePartsLog = rotablePartsLog;
        }
        public RotablePartsLog Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                rotablePartsLog.RotableParts = (RotableParts)repository.SearchOne(rotablePartsLog.RotableParts);
                ((RotablePartsStock)rotablePartsLog.RotablePartsSubClass).RotableParts.ID_RotableParts = rotablePartsLog.RotableParts.ID_RotableParts;
                rotablePartsLog.RotablePartsSubClass = (RotablePartsStock)repository.SearchOne((RotablePartsStock)rotablePartsLog.RotablePartsSubClass);
                if (rotablePartsLog.RotablePartsSubClass == null)
                    Result = null;
                else
                Result = rotablePartsLog;
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da pronađe avionski dio u magacinu avionskih dijelova!");
            }
        }
    }
}
