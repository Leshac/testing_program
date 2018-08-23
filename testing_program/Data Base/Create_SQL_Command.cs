using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_program
{
    class Create_SQL_Command: Working_with_sql
    {
        string sqlQuery;

        public Create_SQL_Command(string _sqlQuery)
        {
            sqlQuery = _sqlQuery;

        }

        public SqlCommand get_SQL_Command()
        {
            Create_SQL_Command create_SQL_Command = new Create_SQL_Command(sqlQuery);
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, connect_to_the_database());
            return (sqlCommand);

        }
    }
}
