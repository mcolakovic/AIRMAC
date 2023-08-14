using System;
using System.Data.Linq;
using Domain;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class ZapamtiRegistracijuSO : SystemOperationBase
    {
        private readonly User user;
        private decimal rowInserted;
        private static Object _lock = new Object();
        public User Result { get; private set; }

        public ZapamtiRegistracijuSO(User user)
        {
            this.user = user;
        }

        protected override void Execute()
        {
            try
            {
                lock (_lock)
                {
                    rowInserted = repository.Add(user);
                }
                Result = user;
            }
            catch (Exception ex)
            {
               if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                    throw new SQLOperationException("Sistem je pronasao istog korisnika u bazi registrovanih korisnika!");
               else
                    throw new SystemOperationException("Sistem ne može da sačuva podatke o novoj registraciji!");
            }
            
        }
    }
}
