using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class LogBook : IDomainObject
    {
        public Decimal ID_LogBook{ get; set; }
        public DateTime FlightDate { get; set; }
        public string FlightNumber { get; set; }
        public Airport Airport_FROM { get; set; }
        public Airport Airport_TO { get; set; }
        public Aircraft Aircraft { get; set; } 
        public DateTime FlightTimeStart { get; set; }
        public DateTime FlightTimeStop { get; set; } 
        public Decimal PreviousACHours { get; set; }
        public Decimal PreviousACCycles { get; set; }
        public Decimal NextACHours { get; set; }
        public Decimal NextACCycles { get; set; }
 
        public List<string> TableName => new List<string> { "LogBook" };
        private int _TableNameIndex;
        public int TableNameIndex { get => _TableNameIndex; set => _TableNameIndex = value; }
        
        public List<string> SelectFields => new List<string> { "LogBook.*" };
        private int _SelectFieldsIndex;
        public int SelectFieldsIndex { get => _SelectFieldsIndex; set => _SelectFieldsIndex = value; }

        public List<string> Condition => new List<string> { $"RegistrationNumber = '{Aircraft?.RegistrationNumber}' AND FlightDate >= convert(datetime, '{FlightTimeStart}', 103) AND FlightDate <= convert(datetime, '{FlightTimeStop}', 103)" , $"ID_LogBook = {ID_LogBook}" };
        private int _ConditionIndex;
        public int ConditionIndex { get => _ConditionIndex; set => _ConditionIndex = value; }

              
        public string InsertValues => $"{Airport_FROM?.ID_Airport}, {Airport_TO?.ID_Airport}, convert(datetime, '{FlightDate.ToString("yyyyMMdd HH:mm:ss")}', 103), '{FlightNumber}', '{Aircraft?.RegistrationNumber}',  convert(datetime, '{FlightTimeStart.ToString("yyyyMMdd HH:mm:ss")}', 103), convert(datetime, '{FlightTimeStop.ToString("yyyyMMdd HH:mm:ss")}', 103), {PreviousACHours}, {PreviousACCycles}, {NextACHours}, {NextACCycles}";

        public string UpdateValues => $"FlightNumber = '{FlightNumber}', FlightTimeStart = convert(datetime, '{FlightTimeStart.ToString("yyyyMMdd HH:mm:ss")}', 103), FlightTimeStop = convert(datetime, '{FlightTimeStop.ToString("yyyyMMdd HH:mm:ss")}', 103)";

        public string SelectOrderBy => "ID_LogBook DESC";

        public List<IDomainObject> ReadMultipleRow(SqlDataReader reader)
        {
            List<IDomainObject> logbook = new List<IDomainObject>();
            while (reader.Read())
            {
                logbook.Add(new LogBook
                {
                    ID_LogBook = reader.GetDecimal(0),
                    FlightDate = reader.GetDateTime(3),
                    FlightNumber = reader.GetString(4),
                    Airport_FROM = new Airport
                    {
                        ID_Airport = reader.GetDecimal(1)
                    },
                    Airport_TO = new Airport
                    {
                        ID_Airport = reader.GetDecimal(2)
                    },
                    Aircraft = new Aircraft
                    {
                        RegistrationNumber = reader.GetString(5)
                    },
                    FlightTimeStart = reader.GetDateTime(6),
                    FlightTimeStop = reader.GetDateTime(7),
                    PreviousACHours = reader.GetDecimal(8),
                    PreviousACCycles = reader.GetDecimal(9),
                    NextACHours = reader.GetDecimal(10),
                    NextACCycles = reader.GetDecimal(11)
                });
            }
            return logbook;
        }

        public IDomainObject ReadSingleRow(SqlDataReader reader)
        {
            IDomainObject logbook;
            if (!reader.HasRows) return null;
            reader.Read();
            
                logbook = new LogBook
                {
                    ID_LogBook = reader.GetDecimal(0),
                    FlightDate = reader.GetDateTime(3),
                    FlightNumber = reader.GetString(4),
                    Airport_FROM = new Airport
                    {
                        ID_Airport = reader.GetDecimal(1)
                    },
                    Airport_TO = new Airport
                    {
                        ID_Airport = reader.GetDecimal(2)
                    },
                    Aircraft = new Aircraft
                    {
                        RegistrationNumber = reader.GetString(5)
                    },
                    FlightTimeStart = reader.GetDateTime(6),
                    FlightTimeStop = reader.GetDateTime(7),
                    PreviousACHours = reader.GetDecimal(8),
                    PreviousACCycles = reader.GetDecimal(9),
                    NextACHours = reader.GetDecimal(10),
                    NextACCycles = reader.GetDecimal(11)
                };
            
            return logbook;

        }
    }
}

