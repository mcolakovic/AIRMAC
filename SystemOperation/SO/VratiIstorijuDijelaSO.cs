using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class VratiIstorijuDijelaSO : SystemOperationBase
    {
        private readonly RotablePartHistory rotablePartHistory;
        public VratiIstorijuDijelaSO(RotablePartHistory rotablePartHistory)
        {
            this.rotablePartHistory = rotablePartHistory;
        }
        public List<RotablePartHistory> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.SearchAll(rotablePartHistory).OfType<RotablePartHistory>().ToList();
            }
            catch (Exception ex)
            {
                throw new SystemOperationException("Sistem ne može da pronađe podatke o istoriji dijela");
            }
        }

    }
}
