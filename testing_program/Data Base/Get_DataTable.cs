using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_program
{
    class Get_DataTable
    {
        string sqlQuery;
        public DataTable datatable;
        public Get_DataTable(string _sqlQuery)
        {
            sqlQuery = _sqlQuery;
        }
        public DataTable get_DataTable()
        {
            datatable = new DataTable();
            Create_sql_data_adapter create_sql_data_adapter = new Create_sql_data_adapter(sqlQuery);
            SqlDataAdapter sqlDataAdapter = create_sql_data_adapter.get_sql_data_adapter();
            sqlDataAdapter.Fill(datatable);
            return (datatable);
        }
    }
}
