using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace testing_program

{

    class Working_with_sql
    {
        const string string_connection = @"Data Source=tcp:93.170.108.82,1433;Initial Catalog=testing_program;Persist Security Info=True;User ID=dba; Password=sql";
        //const string string_connection = @"Data Source=DESKTOP-O70R3EM,1433;Initial Catalog=testing_program;Persist Security Info=True;User ID=dba; Password=sql";
        public SqlConnection connect_to_the_database()
        {
            SqlConnection dbconnect = new SqlConnection(string_connection);
            dbconnect.Open();
            return (dbconnect);
        }
        
    }
    
    

}
