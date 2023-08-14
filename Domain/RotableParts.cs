using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class RotableParts : IDomainObject
    {
        public Decimal ID_RotableParts { get; set; }
        public string PartNumber { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }

        public List<string> TableName => new List<string> { "RotableParts", "RotableParts output inserted.ID_RotableParts" };
        private int _TableNameIndex;
        public int TableNameIndex { get => _TableNameIndex; set => _TableNameIndex = value; }

        public List<string> SelectFields => new List<string> { "RotableParts.*" };
        private int _SelectFieldsIndex;
        public int SelectFieldsIndex { get => _SelectFieldsIndex; set => _SelectFieldsIndex = value; }

        public List<string> Condition => new List<string> { $"PartNumber = '{PartNumber}' AND SerialNumber = '{SerialNumber}'", $"ID_RotableParts = {ID_RotableParts}" };
        private int _ConditionIndex;
        public int ConditionIndex { get => _ConditionIndex; set => _ConditionIndex = value; }

        public string InsertValues => $"'{PartNumber}', '{SerialNumber}', '{Description}'";


        public string UpdateValues => $"Description = '{Description}'";

        public string SelectOrderBy => "ID_RotableParts";

        public List<IDomainObject> ReadMultipleRow(SqlDataReader reader)
        {
            List<IDomainObject> rotableParts = new List<IDomainObject>();
            while (reader.Read())
            {
                rotableParts.Add(new RotableParts
                {
                    ID_RotableParts = reader.GetDecimal(0),
                    PartNumber = reader.GetString(1),
                    SerialNumber = reader.GetString(2),
                    Description = reader.GetString(3)
                });
            }
            return rotableParts;
        }

        public IDomainObject ReadSingleRow(SqlDataReader reader)
        {
            IDomainObject rotableParts;
            if (!reader.HasRows) return null;
            reader.Read();

                rotableParts = new RotableParts
                {
                    ID_RotableParts = reader.GetDecimal(0),
                    PartNumber = reader.GetString(1),
                    SerialNumber = reader.GetString(2),
                    Description = reader.GetString(3)
                };
                return rotableParts;
       
                
                
            
            
        }
    }
}



