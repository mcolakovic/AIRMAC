using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Aircraft : IDomainObject
    {
        public string RegistrationNumber { get; set; }
        public string SerialNumber { get; set; }
        public DateTime LastUpdate { get; set; }
        public Airport Airport { get; set; }
        public Decimal LastACHours { get; set; }
        public Decimal LastACCycles { get; set; }

        public List<string> TableName => new List<string> { "Aircraft" , "Aircraft, Airports", "Aircraft output CAST(@@ROWCOUNT AS DECIMAL(18,0))" };
        private int _TableNameIndex;
        public int TableNameIndex { get => _TableNameIndex; set => _TableNameIndex = value; }

        public List<string> SelectFields => new List<string> { "Aircraft.*" };
        private int _SelectFieldsIndex;
        public int SelectFieldsIndex { get => _SelectFieldsIndex; set => _SelectFieldsIndex = value; }

        public List<string> Condition => new List<string> { "Aircraft.ID_Airport = Airports.ID_Airport", $"Aircraft.ID_Airport = Airports.ID_Airport AND RegistrationNumber = '{RegistrationNumber}'" };
        private int _ConditionIndex;
        public int ConditionIndex { get => _ConditionIndex; set => _ConditionIndex = value; }

        public string InsertValues => $"'{RegistrationNumber}', '{SerialNumber}', convert(datetime, '{LastUpdate.ToString("yyyyMMdd HH:mm:ss")}', 103), {Airport?.ID_Airport}, {LastACHours}, {LastACCycles}";
        public string UpdateValues => "";
        public string SelectOrderBy => "RegistrationNumber ASC";

        public override string ToString()
        {
            return RegistrationNumber;
        }
        public override bool Equals(object obj)
        {
            if (obj is Aircraft a) return a.RegistrationNumber == RegistrationNumber;
            return false;
        }

        public List<IDomainObject> ReadMultipleRow(SqlDataReader reader)
        {
            List<IDomainObject> aircraft = new List<IDomainObject>();
            while (reader.Read())
            {
                aircraft.Add(new Aircraft
                {
                    RegistrationNumber = reader.GetString(0),
                    SerialNumber = reader.GetString(1),
                    LastUpdate = reader.GetDateTime(2),
                    Airport = new Airport
                    {
                        ID_Airport = reader.GetDecimal(3),
                    },
                    LastACHours = reader.GetDecimal(4),
                    LastACCycles = reader.GetDecimal(5)
                });
            }
            return aircraft;
        }

        public IDomainObject ReadSingleRow(SqlDataReader reader)
        {
            IDomainObject aircraft;
            if (!reader.HasRows) return null;
            reader.Read();

            aircraft = new Aircraft
            {
                RegistrationNumber = reader.GetString(0),
                SerialNumber = reader.GetString(1),
                LastUpdate = reader.GetDateTime(2),
                Airport = new Airport
                {
                    ID_Airport = reader.GetDecimal(3),
                },
                LastACHours = reader.GetDecimal(4),
                LastACCycles = reader.GetDecimal(5)
            };

            return aircraft;
        }
    }
}
