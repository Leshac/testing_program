using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace testing_program
{
    public static class test_double_people_for_edu
    {
        public static bool testing_copy(string last_Name, DateTime Birthday)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sqlquery = $"SELECT COUNT(People_for_edu.id) FROM People_for_edu WHERE (People_for_edu.LastName='{last_Name}')AND(People_for_edu.Birthday='{Birthday.Date}')";

            SqlCommand sqlCommand = new SqlCommand(sqlquery,sqlConnection);
            int count_copy=(int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (count_copy > 0)
            {
                MessageBox.Show("Запись с таким человеком уже есть в программе");
                return (false);
            }
            return (true);
        }
    }
}
