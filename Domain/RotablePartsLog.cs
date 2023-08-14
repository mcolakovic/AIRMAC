using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class RotablePartsLog : IDomainObject
    {
        public Decimal ID_RotablePartsLog { get; set; }
        public RotableParts RotableParts { get; set; }
        public int SubClass { get; set; }
        public Object RotablePartsSubClass { get; set; }
        public List<string> TableName => new List<string> { "RotablePartsLog", "RotablePartsLog output inserted.ID_RotablePartsLog" };
        private int _TableNameIndex;
        public int TableNameIndex { get => _TableNameIndex; set => _TableNameIndex = value; }
        public List<string> SelectFields => throw new NotImplementedException();

        public int SelectFieldsIndex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<string> Condition => throw new NotImplementedException();

        public int ConditionIndex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string InsertValues => $"{RotableParts.ID_RotableParts}, {SubClass}";

        public string UpdateValues => throw new NotImplementedException();

        public string SelectOrderBy => throw new NotImplementedException();

        public List<IDomainObject> ReadMultipleRow(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IDomainObject ReadSingleRow(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
