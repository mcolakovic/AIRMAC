using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class ServiceableParts : IDomainObject
    {
        public RotablePartsLog RotablePartsLog { get; set; }
        public RotableParts RotableParts { get; set; }
        public string PartNumber { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public string WorkOrder { get; set; }

        public List<string> TableName => new List<string> { "RotablePartsService, RotableParts" };
        private int _TableNameIndex;
        public int TableNameIndex { get => _TableNameIndex; set => _TableNameIndex = value; }

        public List<string> SelectFields => new List<string> { "RotablePartsService.ID_RotablePartsLog, RotablePartsService.ID_RotableParts, RotableParts.PartNumber, RotableParts.SerialNumber, RotableParts.Description, RotablePartsService.WorkOrder" };
        private int _SelectFieldsIndex;
        public int SelectFieldsIndex { get => _SelectFieldsIndex; set => _SelectFieldsIndex = value; }

        public List<string> Condition => new List<string> { $"ID_RotablePartsLog in (select ID_RotablePartsLog FROM RotablePartsLog t1 Where ID_SubClass = 3 AND (SELECT COUNT(*) FROM RotablePartsLog AS t2 Where t2.ID_RotablePartsLog > t1.ID_RotablePartsLog AND t2.ID_RotableParts = t1.ID_RotableParts) = 0 )  AND ID_ResultOfInspection IS NOT NULL  AND RotablePartsService.ID_RotableParts =  RotableParts.ID_RotableParts" };
        private int _ConditionIndex;
        public int ConditionIndex { get => _ConditionIndex; set => _ConditionIndex = value; }

        public string InsertValues => "";

        public string UpdateValues => "";

        public string SelectOrderBy => "ID_RotableParts";

        public List<IDomainObject> ReadMultipleRow(SqlDataReader reader)
        {
            List<IDomainObject> servicableParts = new List<IDomainObject>();
            while (reader.Read())
            {
                servicableParts.Add(new ServiceableParts
                {
                    RotablePartsLog = new RotablePartsLog
                    {
                        ID_RotablePartsLog = reader.GetDecimal(0)
                    },
                    RotableParts = new RotableParts
                    {
                        ID_RotableParts = reader.GetDecimal(1)
                    },

                    PartNumber = reader.GetString(2),
                    SerialNumber = reader.GetString(3),
                    Description = reader.GetString(4),
                    WorkOrder = reader.GetString(5)

                });
            }
            return servicableParts;
        }

        public IDomainObject ReadSingleRow(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
