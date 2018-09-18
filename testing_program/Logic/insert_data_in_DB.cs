using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace testing_program
{
    public static class insert_data_in_DB
    {
        public static int Insert_in_table_people_for_edu(string LastName, string Name, string FatherName, DateTime Birthday, object id_sex, object id_education, object id_profession, object id_qualification, object id_family, string extra, bool for_edu)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"INSERT INTO People_for_edu (LastName,Name,FatherName,Birthday,id_sex,id_education,id_profession,id_qualification, id_family, extra,for_edu) VALUES('{LastName}', '{Name}', '{FatherName}', '{Birthday}', '{id_sex}', '{id_education}', {id_profession}, '{id_qualification}', '{id_family}', '{extra}', '{for_edu}'); Select SCOPE_IDENTITY(); ";

            SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
            int get_new_id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            return (get_new_id);
        }

        public static int insert_in_table_acc(object id_human, object id_type, object id_seriousness, DateTime Datetime, int Time_acc_work, String Dayweek, int Age_on_accident, bool Alcohol, bool SIZ, int month, int general_exp_on_accident, object id_work, int exp_in_enterprise_on_accident, int exp_on_profession_on_accident)
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

        public static int insert_in_table_Work_action(object id_work_human, object id_work)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"INSERT INTO Work_actions (id_work_human,id_work) VALUES('{id_work_human}', '{id_work}'); Select SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
            int get_new_id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            return (get_new_id);
        }

        public static void insert_in_table_Codes_reason_in_accident(object id_accident,ListBox codes_reason)
        {
            for (int i=0; i < codes_reason.Items.Count; i++)
            {
                if (codes_reason.GetSelected(i))
                {
                    codes_reason.SetSelected(i, true);
                    
                    object id_codes =(object)codes_reason.SelectedValue;
                    codes_reason.SetSelected(i, false);
                    SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
                    sqlConnection.Open();

                    string sql_quiry = $"INSERT INTO Codes_reason_in_accident (id_accident, id_codes) VALUES('{id_accident}', '{id_codes}'); Select SCOPE_IDENTITY();";

                    SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
                    int get_new_id = Convert.ToInt32(sqlCommand.ExecuteScalar());
                 }
            }
            
        }

        public static int insert_in_table_Instruct(object id_type_instruct, object id_topic_instruct, object Date_instr)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"INSERT INTO Instruct (id_type_instruct,id_topic_instruct,Date_instr) VALUES ('{id_type_instruct}','{id_topic_instruct}','{Date_instr}'); Select SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
            int get_new_id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            return (get_new_id);
        }

        public static void insert_in_table_Info_education(object id_human, object id_instruct)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"INSERT INTO Info_education (id_human,id_instruct) VALUES ('{id_human}','{id_instruct}'); Select SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
            int get_new_id = Convert.ToInt32(sqlCommand.ExecuteScalar());
           
        }

        public static int insert_in_table_Check_knowledge(object id_type_check, DateTime Date_check, object id_type_result_check)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"INSERT INTO Check_knowledge (id_type_check,Date_check,id_type_result_check) VALUES ('{id_type_check}','{Date_check}','{id_type_result_check}'); Select SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
            int get_new_id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            return (get_new_id);
        }

        public static void insert_in_table_Info_check_knowledge(object id_human, object id_check)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"INSERT INTO Info_check_knowledge (id_human,id_check) VALUES ('{id_human}','{id_check}'); Select SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
            int get_new_id = Convert.ToInt32(sqlCommand.ExecuteScalar());

        }

        public static int insert_in_table_SOUT_ARM(DateTime Date_sout, bool In_plan, string Khemical, string Microclimate, string Biological, string APFD, string Noise, string iz, string UZ, string VO, string vl, string ni, string II, string ss, string T, string N)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();
            
            string ut=calculation_ut.calculate(Khemical, Microclimate, Biological, APFD, Noise, iz, UZ, VO, vl, ni, II, ss, T, N);         

            string sql_quiry = $"INSERT INTO SOUT_ARM (Date_sout,In_plan,Khemical,Microclimate,Biological,APFD,Noise,iz,UZ,VO,vl,ni,II,ss,T,N,UT) VALUES('{Date_sout}','{In_plan}','{Khemical}','{Microclimate}','{Biological}','{APFD}','{Noise}','{iz}','{UZ}','{VO}','{vl}','{ni}','{II}','{ss}','{T}','{N}','{ut}'); Select SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
            int get_new_id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            return (get_new_id);
        }

        public static void insert_in_table_Workplace(object id_people, object id_sout)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"INSERT INTO Workplace (id_people,id_sout) VALUES ('{id_people}','{id_sout}'); Select SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
            int get_new_id = Convert.ToInt32(sqlCommand.ExecuteScalar());

        }

        public static void insert_in_table_Workplace_OVPF(ListBox ovpf, object id_acc)
        {
            for (int i = 0; i < ovpf.Items.Count; i++)
            {
                
                if (ovpf.GetSelected(i))
                {
                    ovpf.SetSelected(i, true);

                    object id_OVPF = (object)ovpf.SelectedValue;
                    ovpf.SetSelected(i, false);
                    SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
                    sqlConnection.Open();

                    string sql_quiry = $"INSERT INTO Workplace_OVPF (id_OVPF, id_acc) VALUES('{id_OVPF}', '{id_acc}')";

                    SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public static int insert_in_table_datesInstructions(object id_hum, DateTime Date_enter_inst, DateTime Date_last_inst, DateTime Date_last_check,int Time_after_instr,int Time_after_check)
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();

            string sql_quiry = $"INSERT INTO datesInstructions (id_hum, Date_enter_inst,Date_last_inst,Date_last_check,Time_after_instr,Time_after_check) VALUES('{id_hum}','{Date_enter_inst}','{Date_last_inst}','{Date_last_check}','{Time_after_instr}','{Time_after_check}'); Select SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
            int get_new_id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            return (get_new_id);
        }
    }
 }
