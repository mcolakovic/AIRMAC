﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class RemainingHours : IDomainObject
    {
        public Aircraft Aircraft { get; set; }
        public string PartNumber { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public Decimal HoursOperationalLimit { get; set; }
        public Decimal Remaining { get; set; }
        public Decimal ExpireOnHours { get; set; }
        public DateTime Estimated { get; set; }
        public Decimal AlertHours { get; set; } = 1;
        public Decimal UtilisationHours { get; set; }

        public List<string> TableName => new List<string> { "RotablePartsAircraft, RotableParts" };
        private int _TableNameIndex;
        public int TableNameIndex { get => _TableNameIndex; set => _TableNameIndex = value; }

        public List<string> SelectFields => new List<string> { $"RotablePartsAircraft.RegistrationNumber, RotableParts.PartNumber, RotableParts.SerialNumber, RotableParts.Description, RotablePartsAircraft.HoursOperationalLimit, dbo.hours_sub(ExpireOnHours,{Aircraft.LastACHours}) as Remaining, RotablePartsAircraft.ExpireOnHours,  dateadd(d, dbo.hours_sub(ExpireOnHours, {Aircraft.LastACHours}) / {UtilisationHours} ,convert(datetime,'{Aircraft.LastUpdate}',103)) as ESTIMATED" };
        private int _SelectFieldsIndex;
        public int SelectFieldsIndex { get => _SelectFieldsIndex; set => _SelectFieldsIndex = value; }

        public List<string> Condition => new List<string> { $"RotablePartsAircraft.ID_RotableParts = RotableParts.ID_RotableParts AND ID_RotablePartsLog in (select ID_RotablePartsLog FROM RotablePartsLog t1 Where RotablePartsAircraft.HoursOperationalLimit is not null AND RotablePartsAircraft.RegistrationNumber = '{Aircraft.RegistrationNumber}' AND ID_SubClass = 1 AND (SELECT COUNT(*) FROM RotablePartsLog AS t2 Where t2.ID_RotablePartsLog > t1.ID_RotablePartsLog AND t2.ID_RotableParts = t1.ID_RotableParts) = 0 )" };

        private int _ConditionIndex;
        public int ConditionIndex { get => _ConditionIndex; set => _ConditionIndex = value; }

        public string InsertValues => "";

        public string UpdateValues => "";

        public string SelectOrderBy => "PartNumber, SerialNumber";

        public List<IDomainObject> ReadMultipleRow(SqlDataReader reader)
        {
            List<IDomainObject> remainingHours = new List<IDomainObject>();
            while (reader.Read())
            {
                remainingHours.Add(new RemainingHours
                {
                    Aircraft = new Aircraft
                    {
                        RegistrationNumber = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                    },
                    PartNumber = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    SerialNumber = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    Description = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    HoursOperationalLimit = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    Remaining = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5),
                    ExpireOnHours = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6),
                    Estimated = DateTime.Parse(reader.GetDateTime(7).ToString("dd/MM/yyyy"))
                });
            }
            return remainingHours;
        }

        public IDomainObject ReadSingleRow(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
