using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Airport: IDomainObject
    {
        public Decimal ID_Airport { get; set; }
        public string NameOfAirports { get; set; }

        public List<string> TableName => new List<string> { "Airports" };
        private int _TableNameIndex;
        public int TableNameIndex { get => _TableNameIndex; set => _TableNameIndex = value; }

        public List<string> SelectFields => new List<string> { "Airports.*" };
        private int _SelectFieldsIndex;
        public int SelectFieldsIndex { get => _SelectFieldsIndex; set => _SelectFieldsIndex = value; }

        public List<string> Condition => new List<string> { "1 = 1" };
        private int _ConditionIndex;
        public int ConditionIndex { get => _ConditionIndex; set => _ConditionIndex = value; }

        public string InsertValues => $"{ID_Airport}, '{NameOfAirports}'";
        public string SelectOrderBy => "ID_Airport ASC";

        public Airport Self { get { return this; } }

        public string UpdateValues => throw new NotImplementedException();

        public override bool Equals(object obj)
        {
            if (obj is Airport a) return a.ID_Airport == ID_Airport;
            return false;
        }

      
          public override string ToString()
        {
            return NameOfAirports;
        }

        public List<IDomainObject> ReadMultipleRow(SqlDataReader reader)
        {
            List<IDomainObject> airport = new List<IDomainObject>();
            while (reader.Read())
            {
                airport.Add(new Airport
                {
                    ID_Airport = reader.GetDecimal(0),
                    NameOfAirports = reader.GetString(1)
                });
            }
            return airport;
        }

        public IDomainObject ReadSingleRow(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
