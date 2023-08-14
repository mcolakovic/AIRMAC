using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDomainObject
    {
        List<string> TableName { get; }
        int TableNameIndex { get; set; }
        List<string> SelectFields { get; }
        int SelectFieldsIndex { get; set; }
        List<string> Condition { get; }
        int ConditionIndex { get; set; }

        string InsertValues { get; }
        string UpdateValues { get; }
        List<IDomainObject> ReadMultipleRow(SqlDataReader reader);
        IDomainObject ReadSingleRow(SqlDataReader reader);
        string SelectOrderBy { get; }
    }
}
