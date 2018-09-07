using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace testing_program
{
    class update_DB
    {
        public update_DB()
        {

            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_get_id_people = $"SELECT People_for_edu.id From People_for_edu";
            SqlCommand get_id_people = new SqlCommand(sql_get_id_people, sqlConnection);
            SqlDataReader sqlDataReader = get_id_people.ExecuteReader();
            while (sqlDataReader.Read())
            {
                int id_Human = Convert.ToInt32(sqlDataReader.GetValue(0));
                if (Check_people_in_expirience(id_Human))
                {
                    update_Experience(id_Human);
                }
                else
                {
                    insert_Experience_for_people(id_Human);
                    update_Experience(id_Human);
                }

            }
            sqlDataReader.Close();
            sqlConnection.Close();
        }


        private bool Check_people_in_expirience(int id_Human)
        {
            string sql_check_people_in_expirience = $"SELECT Count(Experience.id_human) From Experience Where Experience.id_human={id_Human}";
            SqlConnection connection = new SqlConnection(ConectionSQL_string.sql_string);
            connection.Open();

            SqlCommand command = new SqlCommand(sql_check_people_in_expirience, connection);
            SqlDataReader count_id_human = command.ExecuteReader();

            bool flag = false;
            while (count_id_human.Read())
            {
                if (Convert.ToInt32(count_id_human.GetValue(0)) != 0)
                {
                    return (true);
                }
            }
            connection.Close();
            return (flag);
        }

        private void update_Experience(int id_Human)
        {
            string Update_experience = $"UPDATE Experience Set [general (in_days)]=(SELECT DATEDIFF(DAY,(SELECT MIN(Work.Date_enter) FROM Work  Join Work_actions on Work_actions.id_work=work.id),Acc.Datetime) FROM Work_actions JOIN Work on work.id=Work_actions.id_work JOIN Acc on acc.id_human=Work_actions.id_work_human Where Acc.id_human={id_Human}) Where Experience.id_human={id_Human}";

            SqlConnection update = new SqlConnection(ConectionSQL_string.sql_string);
            update.Open();

            SqlCommand update_command = new SqlCommand(Update_experience, update);
            update_command.ExecuteNonQuery();
            update.Close();
        }

        private void insert_Experience_for_people(int id_Human)
        {
            SqlConnection insert_sql = new SqlConnection(ConectionSQL_string.sql_string);
            insert_sql.Open();

            string String_insert_experirnce_for_human = $"INSERT INTO Experience (id_human,[general (in_days)],[in_enterprise(in_days)],[on_profession(in_days)]) VALUES ({id_Human},0,0,0)";
            SqlCommand insert_command = new SqlCommand(String_insert_experirnce_for_human, insert_sql);
            insert_command.ExecuteNonQuery();

            insert_sql.Close();
        }
    }
}
