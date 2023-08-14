using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class RotablePartHistory : IDomainObject
    {
        public string PartNumber { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public string Action { get; set; }
        public string Details { get; set; }

        public List<string> TableName => new List<string> { "RotableParts, RotablePartsLog" };
        private int _TableNameIndex;
        public int TableNameIndex { get => _TableNameIndex; set => _TableNameIndex = value; }

        public List<string> SelectFields => new List<string> { 
        $@"
        CASE 
            WHEN RotablePartsLog.ID_SubClass = 1 THEN 'Install on Aircraft' 
            WHEN RotablePartsLog.ID_SubClass = 2 THEN
                CASE
                     WHEN (select RegistrationNumber from RotablePartsStock where ID_RotablePartsLog = RotablePartsLog.ID_RotablePartsLog) IS NULL THEN  'Send to Stock'
		             ELSE  'Removed from Aircraft'
	            END
            WHEN RotablePartsLog.ID_SubClass = 3 THEN 'Send to Service'
        END AS Action,
        CASE
            WHEN RotablePartsLog.ID_SubClass = 1 THEN(select 'Instalacija dijela na avion ' + RegistrationNumber + ' dana ' + convert(varchar, InstalationDate,103)  + ' AC HRS: ' + convert(varchar, AircraftHours) + ' AC CYC: ' + convert(varchar, AircraftCycles) from RotablePartsAircraft where ID_RotablePartsLog = RotablePartsLog.ID_RotablePartsLog)
            WHEN RotablePartsLog.ID_SubClass = 2 THEN
                CASE
                     WHEN (select RegistrationNumber from RotablePartsStock where ID_RotablePartsLog = RotablePartsLog.ID_RotablePartsLog) IS NULL THEN(select 'Slanje dijala u magacin avionskih cijelova dana ' + convert(varchar, DateOfEntry,103)  from RotablePartsStock where ID_RotablePartsLog = RotablePartsLog.ID_RotablePartsLog)
                     ELSE(select 'Skidanje dijela sa aviona ' + RegistrationNumber + ' dana ' + convert(varchar, DateOfEntry,103)  + ' AC HRS: ' + convert(varchar, AircraftHours) + ' AC CYC: ' + convert(varchar, AircraftCycles) from RotablePartsStock where ID_RotablePartsLog = RotablePartsLog.ID_RotablePartsLog)
                 END
            WHEN RotablePartsLog.ID_SubClass = 3 THEN(select 'Slanje avionskog dijela na servis WO: ' + WorkOrder +
                      CASE
                          WHEN ID_ResultOfInspection = 1 THEN ' Izvrsena inspekcija: New Operational Limit'
                          WHEN ID_ResultOfInspection = 2 THEN ' Izvrsena inspekcija: Overhaul'
                          WHEN ID_ResultOfInspection = 3 THEN ' Izvrsena inspekcija: Tested'
                          ELSE ' Faza inspekcije u toku'
                      END
                      from RotablePartsService where ID_RotablePartsLog = RotablePartsLog.ID_RotablePartsLog)
            END As Details"
            };
    
        private int _SelectFieldsIndex;

        public int SelectFieldsIndex { get => _SelectFieldsIndex; set => _SelectFieldsIndex = value; }

        public List<string> Condition => new List<string> { $"RotableParts.ID_RotableParts = RotablePartsLog.ID_RotableParts AND RotableParts.PartNumber = '{PartNumber}' AND RotableParts.SerialNumber = '{SerialNumber}' " };
        
        private int _ConditionIndex;
        public int ConditionIndex { get => _ConditionIndex; set => _ConditionIndex = value; }

        public string InsertValues => "";

        public string UpdateValues => "";

        public string SelectOrderBy => "RotablePartsLog.ID_RotablePartsLog";

        public List<IDomainObject> ReadMultipleRow(SqlDataReader reader)
        {
            List<IDomainObject> rotablePartHistory = new List<IDomainObject>();
            while (reader.Read())
            {
                rotablePartHistory.Add(new RotablePartHistory
                {
                    
                    Action = reader.GetString(0),
                    Details = reader.GetString(1)
                });
            }
            return rotablePartHistory;
        }

        public IDomainObject ReadSingleRow(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
