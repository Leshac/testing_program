using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing_program
 
{
   
    public partial class survey_form_ : Form
    {
        
        public survey_form_()
        {
            
            InitializeComponent();
            static_test_result.current_question = static_test_result.current_question + 1;






            Random random = new Random();
            int number_questions = random.Next(1, 10);
            static_test_result.number_question = number_questions;
            static_test_result.numbers_questions[0] = number_questions;
            string sqlString = "Select * From \"question\" Where (number_question='" + number_questions + "')AND(ID_Topics='"+select_test_static.select_topics_test+"') ";
            get_data_question get_Data_Question = new get_data_question(sqlString);
            string text_question = get_Data_Question.Text;
            string sqlStringresponse1 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers1 + "' ";
            string sqlStringresponse2 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers2 + "' ";
            string sqlStringresponse3 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers3 + "' ";
            string sqlStringresponse4 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers4 + "' ";
            string sqlStringresponse5 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers5 + "' ";


            get_data_answers get_Data_Answers1 = new get_data_answers(sqlStringresponse1);
            get_data_answers get_Data_Answers2 = new get_data_answers(sqlStringresponse2);
            get_data_answers get_Data_Answers3 = new get_data_answers(sqlStringresponse3);
            get_data_answers get_Data_Answers4 = new get_data_answers(sqlStringresponse4);
            get_data_answers get_Data_Answers5 = new get_data_answers(sqlStringresponse5);

            richTextBox1.Text = text_question;
            radioButton1.Text = get_Data_Answers1.Text_Answer;
            radioButton2.Text = get_Data_Answers2.Text_Answer;
            radioButton3.Text = get_Data_Answers3.Text_Answer;
            radioButton4.Text = get_Data_Answers4.Text_Answer;
            radioButton5.Text = get_Data_Answers5.Text_Answer;

            if (radioButton3.Text == "нет ответа                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ")
            {
                radioButton3.Visible = false;
            }
            if (radioButton4.Text == "нет ответа                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ")
            {
                radioButton4.Visible = false;
            }
            if (radioButton5.Text == "нет ответа                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ")
            {
                radioButton5.Visible =false;
            }





        }

        private void survey_form__Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {



            string sqlString = "Select * From \"question\" Where (number_question='" + static_test_result.number_question + "')AND(ID_Topics='" + select_test_static.select_topics_test + "') ";
            get_data_question get_Data_Question = new get_data_question(sqlString);


            string sqlStringresponse1 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers1 + "' ";
            string sqlStringresponse2 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers2 + "' ";
            string sqlStringresponse3 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers3 + "' ";
            string sqlStringresponse4 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers4 + "' ";
            string sqlStringresponse5 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers5 + "' ";


            get_data_answers get_Data_Answers1 = new get_data_answers(sqlStringresponse1);
            get_data_answers get_Data_Answers2 = new get_data_answers(sqlStringresponse2);
            get_data_answers get_Data_Answers3 = new get_data_answers(sqlStringresponse3);
            get_data_answers get_Data_Answers4 = new get_data_answers(sqlStringresponse4);
            get_data_answers get_Data_Answers5 = new get_data_answers(sqlStringresponse5);



            if (radioButton1.Checked && Convert.ToBoolean(get_Data_Answers1.correct))
            {
                static_test_result.correct_answer++;
            }
            else
            {
                if (radioButton2.Checked && Convert.ToBoolean(get_Data_Answers2.correct))
                {
                    static_test_result.correct_answer++;
                }
                else
                {
                    if (radioButton3.Checked && Convert.ToBoolean(get_Data_Answers3.correct))
                    {
                        static_test_result.correct_answer++;
                    }
                    else
                    {
                        if (radioButton4.Checked && Convert.ToBoolean(get_Data_Answers4.correct))
                        {
                            static_test_result.correct_answer++;
                        }
                        else
                        {
                            if (radioButton5.Checked && Convert.ToBoolean(get_Data_Answers5.correct))
                            {
                                static_test_result.correct_answer++;
                            }
                            else
                            {
                                static_test_result.not_correct_answer++;
                            }

                        }
                    }
                }


            }




            

                if (static_test_result.current_question <= static_test_result.kolvo_voprosov - 1)
                {
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = true;

                     static_test_result.current_question = static_test_result.current_question + 1;




                


                    Random random = new Random();
                    //int ID_Topics = 1;
                    string sqlStringresponse = "select MAX(number_question) From question WHERE ID_Topics='" + select_test_static.select_topics_test + "'";
                    Create_SQL_Data_Reader create_SQL_Data_Reader = new Create_SQL_Data_Reader(sqlStringresponse);
                    SqlDataReader reader = create_SQL_Data_Reader.get_SQL_Data_Reader();
                    reader.Read();
                    int max_number_question = ((int)reader.GetValue(0));


                    int number_questions = random.Next(1, max_number_question);
                
               for (int i = 1; i <= static_test_result.current_question-2; i++)
                {
                    if (number_questions == static_test_result.numbers_questions[i - 1])
                    {
                        
                            number_questions = random.Next(1, max_number_question);
                            i = 1;
                        

                    }
                }
                static_test_result.numbers_questions[static_test_result.current_question - 1] = number_questions;
                static_test_result.number_question = number_questions;
                    sqlString = "Select * From \"question\" Where (number_question='" + number_questions + "')AND(ID_Topics='" + select_test_static.select_topics_test + "') ";
                    get_data_question get_Data_Question1 = new get_data_question(sqlString);
                    string text_question = get_Data_Question1.Text;
                    sqlStringresponse1 = "Select * From \"Answers\" Where id='" + get_Data_Question1.ID_Answers1 + "' ";
                    sqlStringresponse2 = "Select * From \"Answers\" Where id='" + get_Data_Question1.ID_Answers2 + "' ";
                    sqlStringresponse3 = "Select * From \"Answers\" Where id='" + get_Data_Question1.ID_Answers3 + "' ";
                    sqlStringresponse4 = "Select * From \"Answers\" Where id='" + get_Data_Question1.ID_Answers4 + "' ";
                    sqlStringresponse5 = "Select * From \"Answers\" Where id='" + get_Data_Question1.ID_Answers5 + "' ";


                    get_data_answers get_Data_Answers11 = new get_data_answers(sqlStringresponse1);
                    get_data_answers get_Data_Answers12 = new get_data_answers(sqlStringresponse2);
                    get_data_answers get_Data_Answers13 = new get_data_answers(sqlStringresponse3);
                    get_data_answers get_Data_Answers14 = new get_data_answers(sqlStringresponse4);
                    get_data_answers get_Data_Answers15 = new get_data_answers(sqlStringresponse5);

                    richTextBox1.Text = text_question;
                    radioButton1.Text = get_Data_Answers11.Text_Answer;
                    radioButton2.Text = get_Data_Answers12.Text_Answer;
                    radioButton3.Text = get_Data_Answers13.Text_Answer;
                    radioButton4.Text = get_Data_Answers14.Text_Answer;
                    radioButton5.Text = get_Data_Answers15.Text_Answer;

                    if (radioButton3.Text == "нет ответа                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ")
                    {
                        radioButton3.Visible = false;
                    }
                    if (radioButton4.Text == "нет ответа                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ")
                    {
                        radioButton4.Visible = false;
                    }
                    if (radioButton5.Text == "нет ответа                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ")
                    {
                        radioButton5.Visible = false;
                    }


                }
                else
                {
                    this.Hide();

                    DateTime thisDay = DateTime.Today;
                string sql_result = "INSERT INTO [Result_testing] (id_people_for_edu,correct_questions,not_correct_questions,data_testing,id_topic_of_testing) VALUES (N'" + static_test_result.id_current + "',N'" + static_test_result.correct_answer + "',N'" + static_test_result.not_correct_answer + "','" + thisDay.ToString("d") + "','"+ select_test_static.select_topics_test + "'); ";

                    Create_SQL_Command create_SQL_Command = new Create_SQL_Command(sql_result);
                    SqlCommand sqlCommand = create_SQL_Command.get_SQL_Command();
                    sqlCommand.ExecuteNonQuery();


                string sql_questions_for_good = "select Сorrect_answers_for_good_ From Reference_values ";
                Create_SQL_Data_Reader create_SQL_Data_Reader1 = new Create_SQL_Data_Reader(sql_questions_for_good);
                SqlDataReader reader1 = create_SQL_Data_Reader1.get_SQL_Data_Reader();
                reader1.Read();
                int questions_for_good = ((int)reader1.GetValue(0));

                int id_type_check = 2;
                int id_type_result_check;
                if (questions_for_good <= static_test_result.correct_answer)
                {
                              //тестирование
                     id_type_result_check = 1;     //прошел тестирование
                    
                }
                else
                {
                               //тестирование
                     id_type_result_check = 2;     //не прошел тестирование
                    
                }
                string sql_creeate_check_info = "INSERT INTO [Check_knowledge] (id_type_check,Date_check,id_type_result_check) VALUES (N'" + id_type_check + "',N'" + thisDay.ToString("d") + "',N'" + id_type_result_check + "'); ";

                Create_SQL_Command create_SQL_Command1 = new Create_SQL_Command(sql_creeate_check_info);
                SqlCommand sqlCommand1 = create_SQL_Command1.get_SQL_Command();
                sqlCommand1.ExecuteNonQuery();




                
                string get_lost_id_for_Check_knowledge = "select IDENT_CURRENT('Check_knowledge')";
                Create_SQL_Command create_SQL_Command_get_lost_id_for_table_Check_knowledge = new Create_SQL_Command(get_lost_id_for_Check_knowledge);
                SqlCommand Command_get_lost_id = create_SQL_Command_get_lost_id_for_table_Check_knowledge.get_SQL_Command();
                SqlDataReader reader2 = Command_get_lost_id.ExecuteReader();
                long id_lost_Check_knowledge = 0;
                while (reader2.Read())
                {
                    id_lost_Check_knowledge = Convert.ToInt64(reader2.GetValue(0));
                }
                string sql_create_check_info = "INSERT INTO [Info_check_knowledge] (id_human,id_check) VALUES (N'" + static_test_result.id_current + "',N'" + id_lost_Check_knowledge +  "'); ";

                Create_SQL_Command create_SQL_Command2 = new Create_SQL_Command(sql_create_check_info);
                SqlCommand sqlCommand2 = create_SQL_Command2.get_SQL_Command();
                sqlCommand2.ExecuteNonQuery();



                result result = new result();
                    result.ShowDialog();

                }

            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
