using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDependency.SQLTable
{
    public class tblLogBook
    {
        public Decimal ID_LogBook { get; set; }
        public Decimal ID_Airport_FROM { get; set; }
        public decimal ID_Airport_TO { get; set; }
        public DateTime FlightDate { get; set; }
        public string FlightNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime FlightTimeStart { get; set; }
        public DateTime FlightTimeStop { get; set; }
        public Decimal PreviousACHours { get; set; }
        public Decimal PreviousACCycles { get; set; }
        public Decimal NextACHours { get; set; }
        public Decimal NextACCycles { get; set; }
    }
}
