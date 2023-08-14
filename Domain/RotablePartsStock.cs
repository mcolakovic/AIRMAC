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
    public class RotablePartsStock : IDomainObject
    {
        public RotablePartsLog RotablePartsLog { get; set; }
        public RotableParts RotableParts { get; set; }
        public Aircraft Aircraft { get; set; }
        public Decimal AircraftHours { get; set; }
        public Decimal AircraftCycles { get; set; }
        public DateTime DateOfEntry { get; set; }
        public Decimal? HoursOperationalLimit { get; set; }
        public Decimal? CyclesOperationalLimit { get; set; }
        public Decimal? DaysOperationalLimit { get; set; }
        public Decimal? StorageLimit { get; set; }
        public Decimal? TimeSinceNew { get; set; }
        public Decimal? CyclesSinceNew { get; set; }
        public Decimal? DaysSinceNew { get; set; }
        public Decimal? TimeSinceOverhaul { get; set; }
        public Decimal? CyclesSinceOverhaul { get; set; }
        public Decimal? DaysSinceOverhaul { get; set; }
        public DateTime? ExpireAtDate { get; set; }
        public Boolean IsInitial { get; set; }

        public List<string> TableName => new List<string> { "RotablePartsStock", "RotablePartsStock output inserted.ID_RotablePartsLog" };
        private int _TableNameIndex;
        public int TableNameIndex { get => _TableNameIndex; set => _TableNameIndex = value; }

        public List<string> SelectFields => new List<string> { "RotablePartsStock.*" };
        private int _SelectFieldsIndex;
        public int SelectFieldsIndex { get => _SelectFieldsIndex; set => _SelectFieldsIndex = value; }

        public List<string> Condition => new List<string> { $"ID_RotablePartsLog = (select ID_RotablePartsLog FROM RotablePartsLog t1 Where ID_RotableParts = { RotableParts?.ID_RotableParts } AND ID_SubClass = 2 AND (SELECT COUNT(*) FROM RotablePartsLog AS t2 Where t2.ID_RotablePartsLog > t1.ID_RotablePartsLog AND  t2.ID_RotableParts = t1.ID_RotableParts) = 0 )", $"ID_RotablePartsLog = {RotablePartsLog?.ID_RotablePartsLog} AND ID_RotableParts = {RotableParts?.ID_RotableParts}" };
        private int _ConditionIndex;
        public int ConditionIndex { get => _ConditionIndex; set => _ConditionIndex = value; }


        public string InsertValues => $"{RotablePartsLog.ID_RotablePartsLog}, {RotableParts.ID_RotableParts}, NULLIF('{Aircraft?.RegistrationNumber}',''), NULLIF({AircraftHours}, 0), NULLIF({AircraftCycles}, 0), convert(datetime, '{DateOfEntry.ToString("yyyyMMdd HH:mm:ss")}', 103), NULLIF({HoursOperationalLimit ?? -1},-1),  NULLIF({CyclesOperationalLimit ?? -1},-1),  NULLIF({DaysOperationalLimit ?? -1},-1),  NULLIF({StorageLimit ?? -1},-1),  NULLIF({TimeSinceNew ?? -1},-1),  NULLIF({CyclesSinceNew ?? -1},-1),  NULLIF({DaysSinceNew ?? -1},-1),  NULLIF({TimeSinceOverhaul ?? -1},-1),  NULLIF({CyclesSinceOverhaul ?? -1},-1),  NULLIF({DaysSinceOverhaul ?? -1},-1),  NULLIF(convert(datetime, '{ExpireAtDate?.ToString("yyyyMMdd HH:mm:ss")}'),convert(datetime,'1/1/1900',103)), '{IsInitial}'";

        //public string UpdateValues => $"DateOfEntry = convert(datetime, '{DateOfEntry.ToString("yyyyMMdd HH:mm:ss")}', 103), HoursOperationalLimit = {HoursOperationalLimit}, CyclesOperationalLimit = {CyclesOperationalLimit}, DaysOperationalLimit = {DaysOperationalLimit}, StorageLimit = {StorageLimit}, TimeSinceNew = {TimeSinceNew}, CyclesSinceNew = {CyclesSinceNew}, DaysSinceNew = {DaysSinceNew}, TimeSinceOverhaul = {TimeSinceOverhaul}, CyclesSinceOverhaul = {CyclesSinceOverhaul}, DaysSinceOverhaul = {DaysSinceOverhaul},  ExpireAtDate = convert(datetime, '{ExpireAtDate?.ToString("yyyyMMdd HH:mm:ss")}')";
        public string UpdateValues => $"DateOfEntry = convert(datetime, '{DateOfEntry.ToString("yyyyMMdd HH:mm:ss")}', 103), HoursOperationalLimit = NULLIF({HoursOperationalLimit ?? -1},-1), CyclesOperationalLimit = NULLIF({CyclesOperationalLimit ?? -1},-1), DaysOperationalLimit = NULLIF({DaysOperationalLimit ?? -1},-1), StorageLimit = NULLIF({StorageLimit ?? -1},-1), TimeSinceNew = NULLIF({TimeSinceNew ?? -1},-1), CyclesSinceNew = NULLIF({CyclesSinceNew ?? -1},-1), DaysSinceNew = NULLIF({DaysSinceNew ?? -1},-1), TimeSinceOverhaul = NULLIF({TimeSinceOverhaul ?? -1},-1), CyclesSinceOverhaul = NULLIF({CyclesSinceOverhaul ?? -1},-1), DaysSinceOverhaul = NULLIF({DaysSinceOverhaul ?? -1},-1),  ExpireAtDate = NULLIF(convert(datetime, '{ExpireAtDate?.ToString("yyyyMMdd HH:mm:ss")}'),convert(datetime,'1/1/1900',103))";

        public string SelectOrderBy => "ID_RotableParts";

        public List<IDomainObject> ReadMultipleRow(SqlDataReader reader)
        {
            List<IDomainObject> rotablePartsStock = new List<IDomainObject>();
            while (reader.Read())
            {
                rotablePartsStock.Add(new RotablePartsStock
                {
                    RotablePartsLog = new RotablePartsLog
                    {
                        ID_RotablePartsLog = reader.GetDecimal(0)
                    },
                    RotableParts = new RotableParts
                    {
                        ID_RotableParts = reader.GetDecimal(1)
                    },
                    Aircraft = new Aircraft
                    {
                        RegistrationNumber = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    },
                    AircraftHours = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    AircraftCycles = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    DateOfEntry = reader.GetDateTime(5),
                    HoursOperationalLimit = reader.IsDBNull(6) ? (decimal?)null : reader.GetDecimal(6),
                    CyclesOperationalLimit = reader.IsDBNull(7) ? (decimal?)null : reader.GetDecimal(7),
                    DaysOperationalLimit = reader.IsDBNull(8) ? (decimal?)null : reader.GetDecimal(8),
                    StorageLimit = reader.IsDBNull(9) ? (decimal?)null : reader.GetDecimal(9),
                    TimeSinceNew = reader.IsDBNull(10) ? (decimal?)null : reader.GetDecimal(10),
                    CyclesSinceNew = reader.IsDBNull(11) ? (decimal?)null : reader.GetDecimal(11),
                    DaysSinceNew = reader.IsDBNull(12) ? (decimal?)null : reader.GetDecimal(12),
                    TimeSinceOverhaul = reader.IsDBNull(13) ? (decimal?)null : reader.GetDecimal(13),
                    CyclesSinceOverhaul = reader.IsDBNull(14) ? (decimal?)null : reader.GetDecimal(14),
                    DaysSinceOverhaul = reader.IsDBNull(15) ? (decimal?)null : reader.GetDecimal(15),
                    ExpireAtDate = reader.IsDBNull(16) ? (DateTime?)null : reader.GetDateTime(16),
                    IsInitial = reader.GetBoolean(17)

                });
            }
            return rotablePartsStock;
        }

        public IDomainObject ReadSingleRow(SqlDataReader reader)
        {
            IDomainObject rotablePartsStock;
            if (!reader.HasRows) return null;

            reader.Read();
            
                rotablePartsStock = new RotablePartsStock
                {
                    RotablePartsLog = new RotablePartsLog
                    {
                        ID_RotablePartsLog = reader.GetDecimal(0)
                    },
                    RotableParts = new RotableParts
                    {
                        ID_RotableParts = reader.GetDecimal(1)
                    },
                    Aircraft = new Aircraft
                    {
                        RegistrationNumber = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    },
                    AircraftHours = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    AircraftCycles = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    DateOfEntry = reader.GetDateTime(5),
                    HoursOperationalLimit = reader.IsDBNull(6) ? (decimal?)null : reader.GetDecimal(6),
                    CyclesOperationalLimit = reader.IsDBNull(7) ? (decimal?)null : reader.GetDecimal(7),
                    DaysOperationalLimit = reader.IsDBNull(8) ? (decimal?)null : reader.GetDecimal(8),
                    StorageLimit = reader.IsDBNull(9) ? (decimal?)null : reader.GetDecimal(9),
                    TimeSinceNew = reader.IsDBNull(10) ? (decimal?)null : reader.GetDecimal(10),
                    CyclesSinceNew = reader.IsDBNull(11) ? (decimal?)null : reader.GetDecimal(11),
                    DaysSinceNew = reader.IsDBNull(12) ? (decimal?)null : reader.GetDecimal(12),
                    TimeSinceOverhaul = reader.IsDBNull(13) ? (decimal?)null : reader.GetDecimal(13),
                    CyclesSinceOverhaul = reader.IsDBNull(14) ? (decimal?)null : reader.GetDecimal(14),
                    DaysSinceOverhaul = reader.IsDBNull(15) ? (decimal?)null : reader.GetDecimal(15),
                    ExpireAtDate = reader.IsDBNull(16) ? (DateTime?)null : reader.GetDateTime(16),
                    IsInitial = reader.GetBoolean(17)

                };
            
            return rotablePartsStock;
        }
    }
}