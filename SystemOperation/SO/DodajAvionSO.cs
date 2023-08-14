using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class DodajAvionSO : SystemOperationBase
    {
        private readonly Aircraft aircraft;
        private decimal rowInserted;
        private static Object _lock = new Object();
        public Aircraft Result { get; private set; }

        public DodajAvionSO(Aircraft aircraft)
        {
            this.aircraft = aircraft;
        }

        protected override void Execute()
        {
            try
            {
                lock (_lock)
                {
                    rowInserted = repository.Add(aircraft);
                }
                Result = aircraft;
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                    throw new SQLOperationException("Sistem je pronasao istu registraciju u bazi registrovanih aviona!");
                else
                    throw new SystemOperationException("Sistem ne može da sačuva podatke o avionu!");
            }

        }
    }
}
