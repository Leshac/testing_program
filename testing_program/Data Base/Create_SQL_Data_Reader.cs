using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_program
{
    class Create_SQL_Data_Reader
    {
        string sqlQuery;

        public Create_SQL_Data_Reader(string _sqlQuery)
        {
            sqlQuery = _sqlQuery;
        }

        public SqlDataReader get_SQL_Data_Reader()
        {
            Create_SQL_Command create_SQL_Command = new Create_SQL_Command(sqlQuery);
            SqlDataReader reader = create_SQL_Command.get_SQL_Command().ExecuteReader();
            return (reader);
        }

    }
}
