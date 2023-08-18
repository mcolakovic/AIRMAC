using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class VerifikacijaKorisnikaSO : SystemOperationBase
    {
        private readonly User user;

        public VerifikacijaKorisnikaSO(User user)
        {
            this.user = user;
        }
        public User Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = (User)repository.SearchOne(user);
                
            }
            catch (Exception)
            {
                throw new SystemOperationException("Sistem ne može da pronađe podatke o korisniku!");
            }
        }
    }
}
