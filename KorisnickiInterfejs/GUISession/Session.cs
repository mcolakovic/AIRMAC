using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.GUISession
{
   public class Session
    {
        public string Username { get; set; }
        public DateTime LogBookCurrentDate { get; set; } = DateTime.MinValue;
        public Aircraft LogBookCurrentAircraft { get; set; } = null;
        public string CurrentUnserviceablePartNumber { get; set; }
        public string CurrentUnserviceableSerialNumber { get; set; }
        public Decimal CurrentUnserviceableID_RotablePartsLog { get; set; }

        public string CurrentServiceablePartNumber { get; set; }
        public string CurrentServiceableSerialNumber { get; set; }
        public Decimal CurrentServiceableID_RotablePartsLog { get; set; }

        private static Session instance;
        private Session()
        {
        }

        public static Session Instance
        {
            get
            {
                if (instance == null) instance = new Session();
                return instance;
            }
        }
    }
}
