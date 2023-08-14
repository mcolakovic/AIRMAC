using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DBRepository
{
    public interface IRepository<T> where T : class
    {
        Decimal Add(T t);
        void Update(T t);
        void Delete(T t);
        List<T> SearchAll(T t);
        T SearchOne(T t);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
