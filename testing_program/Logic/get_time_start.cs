using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_program
{
   public static class get_time_start
    {
        public static int time_start(object id_Shedule,string TimeOfDay_acc)
        {
            
                SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
                sqlConnection.Open();

                string sql_quiry = $"SELECT Time_start FROM Shedule Where Shedule.id='{id_Shedule}'; ";

                SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
                object time_start_work = sqlCommand.ExecuteScalar();
                System.DateTime time_start = System.DateTime.Parse(Convert.ToString(time_start_work));

                System.DateTime time_acc = System.DateTime.Parse(TimeOfDay_acc);
                System.TimeSpan time_nach = time_acc.TimeOfDay.Subtract(time_start.TimeOfDay);
                int time = Convert.ToInt32(time_nach.TotalMinutes);
                return (time);
            
        }
    }
}
