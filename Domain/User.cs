using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class User : IDomainObject
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string IPAddress { get; set; }
        public string LogTime { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is User u) return u.Username == Username && u.Password == Password;
            return false;
        }

        public List<string> TableName => new List<string> { "Credentials", "Credentials output CAST(@@ROWCOUNT AS DECIMAL(18,0))" };
        private int _TableNameIndex;
        public int TableNameIndex { get => _TableNameIndex; set => _TableNameIndex = value; }

        public List<string> SelectFields => new List<string> { "Credentials.*" };
        private int _SelectFieldsIndex;
        public int SelectFieldsIndex { get => _SelectFieldsIndex; set => _SelectFieldsIndex = value; }

        public List<string> Condition => new List<string> { $"Username = '{Username}' AND Password = '{Password}'" };

        private int _ConditionIndex;
        public int ConditionIndex { get => _ConditionIndex; set => _ConditionIndex = value; }


        public string InsertValues => $"'{Username}', '{Password}', '{Firstname}', '{Lastname}', '{Address}', '{Phone}', '{Country}'";

        public string UpdateValues => "";

        public string SelectOrderBy => "Username ASC";

        public List<IDomainObject> ReadMultipleRow(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IDomainObject ReadSingleRow(SqlDataReader reader)
        {
            IDomainObject user;
            if (!reader.HasRows) return null;
            reader.Read();

            user = new User
            {
                Username = reader.GetString(0),
                Password = reader.GetString(1),
                Firstname = reader.GetString(2),
                Lastname = reader.GetString(3),
                Address = reader.GetString(4),
                Phone = reader.GetString(5),
                Country  = reader.GetString(6)
            };

            return user;
        }
    }
}
