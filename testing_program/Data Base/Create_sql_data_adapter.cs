using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_program
{
    class Create_sql_data_adapter : Working_with_sql
    {
        string sqlQuery;


        public Create_sql_data_adapter(string _sqlQuery)
        {
            sqlQuery = _sqlQuery;

        }

        public SqlDataAdapter get_sql_data_adapter()
        {
            Create_sql_data_adapter create_sql_data_adapter = new Create_sql_data_adapter(sqlQuery);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, connect_to_the_database());
            return (sqlDataAdapter);

        }
    }
}
