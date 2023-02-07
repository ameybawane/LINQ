using System.Data;
using System.Data.SqlClient;

namespace LinqToDs.Data_Source
{
    class EmployeesRepository
    {
        private static readonly string _connectionString;
        static EmployeesRepository()
        {
            _connectionString = @"Data Source=IN-LT-SPARE09\SQL2019;Initial Catalog=EmployeeDb;Integrated Security=True;";
        }
        public DataTable GetAll()
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "select id,name from Employees";
                    sqlCommand.Connection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    return dataTable;
                }
            }
        }
    }
}
