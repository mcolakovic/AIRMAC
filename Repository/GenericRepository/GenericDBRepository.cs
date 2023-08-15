using Repository.DBRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using DatabaseBroker;
using System.Data.SqlClient;
using System.Reflection;

namespace Repository.GenericRepository
{
    public class GenericDBRepository : IRepository<IDomainObject>
    {
        private Broker broker = new Broker();

        public Decimal Add(IDomainObject t)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"INSERT INTO {t.TableName[t.TableNameIndex]} VALUES({t.InsertValues})";                                 
            return (Decimal)command.ExecuteScalar();
        }

        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Delete(IDomainObject t)
        {
            throw new NotImplementedException();
        }

        
        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public List<IDomainObject> SearchAll(IDomainObject t)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"SELECT {t.SelectFields[t.SelectFieldsIndex]} FROM {t.TableName[t.TableNameIndex]} WHERE {t.Condition[t.ConditionIndex]} ORDER BY {t.SelectOrderBy}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                return t.ReadMultipleRow(reader);
            }
        }

        public IDomainObject SearchOne(IDomainObject t)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"SELECT {t.SelectFields[t.SelectFieldsIndex]} FROM {t.TableName[t.TableNameIndex]} WHERE {t.Condition[t.ConditionIndex]} ORDER BY {t.SelectOrderBy}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                return t.ReadSingleRow(reader);
            }
        }

        public void Update(IDomainObject t)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"UPDATE {t.TableName[t.TableNameIndex]} SET {t.UpdateValues} WHERE {t.Condition[t.ConditionIndex]}";
            command.ExecuteNonQuery();
        }
    }
}
