using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class NadjiKartonSO : SystemOperationBase
    {
        private RotableParts rotableParts;
        public NadjiKartonSO(RotableParts rotableParts)
        {
            this.rotableParts = rotableParts;
        }
        public RotableParts Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = (RotableParts)repository.SearchOne(rotableParts);
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da pronađe karton avionskog dijela u evidenciji avio djelova!");
            }
        }
    }
}


