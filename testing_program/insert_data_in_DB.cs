using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace testing_program
{
   public static class insert_data_in_DB
    {
        public static int Insert_in_table_people_for_edu(string LastName, string Name, string FatherName,DateTime Birthday, object id_sex, object id_education, object id_profession, object id_qualification, object id_family, string extra, bool for_edu)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"INSERT INTO People_for_edu (LastName,Name,FatherName,Birthday,id_sex,id_education,id_profession,id_qualification, id_family, extra,for_edu) VALUES('{LastName}', '{Name}', '{FatherName}', '{Birthday}', '{id_sex}', '{id_education}', {id_profession}, '{id_qualification}', '{id_family}', '{extra}', '{for_edu}'); Select SCOPE_IDENTITY(); ";

            SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
            int get_new_id = Convert.ToInt32( sqlCommand.ExecuteScalar());
            return (get_new_id);
        }

        public static int insert_in_table_acc(object id_human, object id_type, object id_seriousness, DateTime Datetime,int Time_acc_work,int Dayweek, int Age_on_accident,bool Alcohol,bool SIZ,int month,int general_exp_on_accident, object id_work, int exp_in_enterprise_on_accident,int exp_on_profession_on_accident)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"INSERT INTO Acc (id_human, id_type, id_seriousness,[Datetime],[Time_acc_work(in hours)], Dayweek, Age_on_accident, Alcohol, SIZ,[month], general_exp_on_accident, id_work, exp_in_enterprise_on_accident, exp_on_profession_on_accident) VALUES('{id_human}', '{id_type}', '{id_seriousness}', '{Datetime}', '{Time_acc_work}', '{Dayweek}', '{Age_on_accident}', '{Alcohol}', '{SIZ}','{month}', '{general_exp_on_accident}', '{id_work}', '{exp_in_enterprise_on_accident}', '{exp_on_profession_on_accident}'); Select SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
            int get_new_id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            return (get_new_id);
        }

        public static int insert_in_table_Work(object id_enterprise, DateTime Date_enter, DateTime Date_remove, bool work_on_prof, object id_work_schedule, object id_conditions, bool internship, DateTime Date_start_internship, DateTime Date_end_internship)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"INSERT INTO WORK (id_enterprise,Date_enter,Date_remove,work_on_prof,id_work_schedule,internship,Date_start_internship,Date_end_internship) VALUES('{id_enterprise}', '{Date_enter}', '{Date_remove}', '{work_on_prof}', '{id_work_schedule}', '{internship}', '{Date_start_internship}', '{Date_end_internship}'); Select SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
            int get_new_id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            return (get_new_id);
        }
    }
}
