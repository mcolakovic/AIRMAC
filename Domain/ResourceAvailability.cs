using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class ResourceAvailability : IDomainObject
    {
        public Aircraft Aircraft { get; set; }
        public string PartNumber { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }

        public Decimal? RemainingHours { get; set; }
        public Decimal? RemainingCycles { get; set; }
        public Decimal? RemainingDays { get; set; }


        public List<string> TableName => new List<string> { "RotablePartsAircraft, RotableParts, Aircraft" };
        private int _TableNameIndex;
        public int TableNameIndex { get => _TableNameIndex; set => _TableNameIndex = value; }

        public List<string> SelectFields => new List<string> { "Aircraft.RegistrationNumber, RotableParts.PartNumber, RotableParts.SerialNumber, RotableParts.Description, CONVERT(DECIMAL(18,2), dbo.hours_sub(ExpireOnHours, LastACHours)) As RemHours, CONVERT(DECIMAL(18,0), (ExpireOnCycles - LastACCycles)) As RemCycles, CONVERT(DECIMAL(18,0), DATEDIFF(day, LastUpdate, ExpireAtDate)) AS RemDays" };
        private int _SelectFieldsIndex;
        public int SelectFieldsIndex { get => _SelectFieldsIndex; set => _SelectFieldsIndex = value; }

        public List<string> Condition => new List<string> { $"RotablePartsAircraft.ID_RotableParts = RotableParts.ID_RotableParts AND RotablePartsAircraft.RegistrationNumber = Aircraft.RegistrationNumber AND RotablePartsAircraft.ID_RotablePartsLog in (select ID_RotablePartsLog FROM RotablePartsLog t1 Where ID_SubClass = 1 AND (SELECT COUNT(*) FROM RotablePartsLog AS t2 Where t2.ID_RotablePartsLog > t1.ID_RotablePartsLog AND t2.ID_RotableParts = t1.ID_RotableParts) = 0 ) AND RotablePartsAircraft.RegistrationNumber = '{Aircraft?.RegistrationNumber}'" };
        private int _ConditionIndex;
        public int ConditionIndex { get => _ConditionIndex; set => _ConditionIndex = value; }

        public string InsertValues => "";

        public string UpdateValues => "";

        public string SelectOrderBy => "PartNumber";

        public List<IDomainObject> ReadMultipleRow(SqlDataReader reader)
        {
            List<IDomainObject> resourceAvailability = new List<IDomainObject>();
            while (reader.Read())
            {
                resourceAvailability.Add(new ResourceAvailability
                {
                    Aircraft = new Aircraft { RegistrationNumber = reader.GetString(0) },
                    PartNumber = reader.GetString(1),
                    SerialNumber = reader.GetString(2),
                    Description = reader.GetString(3),
                    RemainingHours = reader.IsDBNull(4) ? (decimal?)null : reader.GetDecimal(4),
                    RemainingCycles = reader.IsDBNull(5) ? (decimal?)null : reader.GetDecimal(5),
                    RemainingDays = reader.IsDBNull(6) ? (decimal?)null : reader.GetDecimal(6)
                });
            }
            return resourceAvailability;
        }

        public IDomainObject ReadSingleRow(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
