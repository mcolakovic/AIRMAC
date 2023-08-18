using System.Data.SqlClient;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using SQLDependency.SQLTable;
using TableDependency.SqlClient.Base.EventArgs;

namespace SQLDependency
{
    public class Dependency
    {
        private static Dependency instance;
        private string connection_string = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AIRMAC;Integrated Security=True; User Id = airmac; Password=infomont";
        public SqlTableDependency<tblLogBook> tblLogBook_dependency;

        private Dependency()
        {
        }
        public static Dependency Instance
        {
            get
            {
                if (instance == null) instance = new Dependency();
                return instance;
            }
        }

        public void start_dependency()
        {
            SqlDependency.Start(connection_string);
            LogBook_dependency();
        }
        public void stop_dependency()
        {
            SqlDependency.Stop(connection_string);
        }
        public void LogBook_dependency()
        {
            var mapper = new ModelToTableMapper<tblLogBook>();
            mapper.AddMapping(s => s.ID_LogBook, "ID_LogBook");
            mapper.AddMapping(s => s.ID_Airport_FROM, "ID_Airport_FROM");
            mapper.AddMapping(s => s.ID_Airport_TO, "ID_Airport_TO");
            mapper.AddMapping(s => s.FlightDate, "FlightDate");
            mapper.AddMapping(s => s.FlightNumber, "FlightNumber");
            mapper.AddMapping(s => s.RegistrationNumber, "RegistrationNumber");
            mapper.AddMapping(s => s.FlightTimeStart, "FlightTimeStart");
            mapper.AddMapping(s => s.FlightTimeStop, "FlightTimeStop");
            mapper.AddMapping(s => s.PreviousACHours, "PreviousACHours");
            mapper.AddMapping(s => s.PreviousACCycles, "PreviousACCycles");
            mapper.AddMapping(s => s.NextACHours, "NextACHours");
            mapper.AddMapping(s => s.NextACCycles, "NextACCycles");

            tblLogBook_dependency = new SqlTableDependency<tblLogBook>(connection_string, tableName: "LogBook", schemaName: "dbo", mapper: mapper);
            tblLogBook_dependency.OnChanged += tblLogBook_dependency_Changed;
            tblLogBook_dependency.Start();
        }

        private void tblLogBook_dependency_Changed(object sender, RecordChangedEventArgs<tblLogBook> e)
        {
            ObserverPatern.Objects.ServerObject.Notify();
        }
    }
}
