using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_program
{

    class Fuzzy_Sets
    {
        int all_acc = 0;

        public void test()
        {
            count_old_in_acc count_Old_18_24 = new count_old_in_acc(18, 25);
            count_old_in_acc count_Old_25_29 = new count_old_in_acc(25, 30);
            count_old_in_acc count_Old_30_34 = new count_old_in_acc(30, 35);
            count_old_in_acc count_Old_35_39 = new count_old_in_acc(35, 40);
            count_old_in_acc count_Old_40_44 = new count_old_in_acc(40, 45);
            count_old_in_acc count_Old_45_49 = new count_old_in_acc(45, 50);
            count_old_in_acc count_Old_50_54 = new count_old_in_acc(50, 55);
            count_old_in_acc count_Old_55_59 = new count_old_in_acc(55, 60);
            get_all_acc();
            double pi_18_25= get_hit_frequency(count_Old_18_24.get_count_old());

            int b = 1;
        }

        private void get_all_acc()
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sqlquery = $"SELECT COUNT (acc.id_accident) FROM acc";

            SqlCommand sqlCommand = new SqlCommand(sqlquery, sqlConnection);
            all_acc = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
        }
        private  double get_hit_frequency(int count_index)
        {
            double pi = (double)count_index / (double)all_acc;
            return (pi);
        }
    }
}
