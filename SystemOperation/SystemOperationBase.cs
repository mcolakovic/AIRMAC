using Domain;
using Repository.DBRepository;
using Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public abstract class SystemOperationBase
    {
        protected IRepository<IDomainObject> repository = new GenericDBRepository();

        public void ExecuteTemplate()
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                Execute();
                repository.Commit();
            }
            catch(Exception ex)
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }

        protected abstract void Execute();             //template method pattern

    }
}
