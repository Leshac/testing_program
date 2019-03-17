using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace testing_program
{
    class count_old_in_acc:Fuzzy_Sets
    {
        int count_old=0;
        int min_year=0;
        int max_year=0;

        public count_old_in_acc(int _min_year, int _max_year)
        {
            min_year = _min_year;
            max_year = _max_year;
           // get_old_in_acc(min_year,max_year);
        }

        private void get_old_in_acc(int min_year, int max_year)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sqlquery = $"SELECT COUNT(pfu.id) FROM People_for_edu pfu JOIN Acc _acc on _acc.id_human = pfu.ID WHERE(DATEDIFF(YEAR, pfu.Birthday, _acc.Datetime) >= '{min_year}')AND(DATEDIFF(YEAR, pfu.Birthday, _acc.Datetime) < '{max_year}')";

            SqlCommand sqlCommand = new SqlCommand(sqlquery,sqlConnection);
            count_old=(int)sqlCommand.ExecuteScalar();

            sqlConnection.Close();
        }

        public int get_count_old()
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sqlquery = $"SELECT Count(Age_on_accident) From Acc Where Age_on_accident>= "+min_year+" AND Age_on_accident < "+max_year+"";
            SqlCommand sqlCommand = new SqlCommand(sqlquery, sqlConnection);
            count_old = (int)sqlCommand.ExecuteScalar();

            sqlConnection.Close();

            return (count_old);
        }
    }
}
