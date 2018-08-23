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
    public partial class Form_new_questions : Form
    {
        public Form_new_questions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_correct_answers1.Checked == true || rb_correct_answers2.Checked == true || rb_correct_answers3.Checked == true || rb_correct_answers4.Checked == true || rb_correct_answers5.Checked == true)
            {
                string sqlString_Answers1 = "INSERT INTO [Answers] (answer,correct) VALUES (N'" + tb_new_Answers1.Text + "','" + rb_correct_answers1.Checked + "');";
                string sqlString_Answers2 = "INSERT INTO [Answers] (answer,correct) VALUES (N'" + tb_new_Answers2.Text + "','" + rb_correct_answers2.Checked + "');";
                string sqlString_Answers3 = "INSERT INTO [Answers] (answer,correct) VALUES (N'" + tb_new_Answers3.Text + "','" + rb_correct_answers3.Checked + "');";
                string sqlString_Answers4 = "INSERT INTO [Answers] (answer,correct) VALUES (N'" + tb_new_Answers4.Text + "','" + rb_correct_answers4.Checked + "');";
                string sqlString_Answers5 = "INSERT INTO [Answers] (answer,correct) VALUES (N'" + tb_new_Answers5.Text + "','" + rb_correct_answers5.Checked + "');";

                string sqlString_get_id_Answers1 = "SELECT MAX(Id) FROM [Answers] WHERE answer=N'" + tb_new_Answers1.Text + "';";
                string sqlString_get_id_Answers2 = "SELECT MAX(Id) FROM [Answers] WHERE answer=N'" + tb_new_Answers2.Text + "';";
                string sqlString_get_id_Answers3 = "SELECT MAX(Id) FROM [Answers] WHERE answer=N'" + tb_new_Answers3.Text + "';";
                string sqlString_get_id_Answers4 = "SELECT MAX(Id) FROM [Answers] WHERE answer=N'" + tb_new_Answers4.Text + "';";
                string sqlString_get_id_Answers5 = "SELECT MAX(Id) FROM [Answers] WHERE answer=N'" + tb_new_Answers5.Text + "';";
                int ID_Answers3=9;
                int ID_Answers4=9;
                int ID_Answers5=9;

                //создание вопросов в БД
                Create_SQL_Command create_SQL_Command1 = new Create_SQL_Command(sqlString_Answers1);
                SqlCommand sqlCommand1 = create_SQL_Command1.get_SQL_Command();
                sqlCommand1.ExecuteNonQuery();

                Create_SQL_Data_Reader create_SQL_Data_Reader1 = new Create_SQL_Data_Reader(sqlString_get_id_Answers1);
                SqlDataReader reader1 = create_SQL_Data_Reader1.get_SQL_Data_Reader();
                reader1.Read();
                int ID_Answers1 = (int)reader1.GetValue(0);

                ////////////////////////////////////////////////////////////////////////////////////////////////

                Create_SQL_Command create_SQL_Command2 = new Create_SQL_Command(sqlString_Answers2);
                SqlCommand sqlCommand2 = create_SQL_Command2.get_SQL_Command();
                sqlCommand2.ExecuteNonQuery();

                Create_SQL_Data_Reader create_SQL_Data_Reader2 = new Create_SQL_Data_Reader(sqlString_get_id_Answers2);
                SqlDataReader reader2 = create_SQL_Data_Reader2.get_SQL_Data_Reader();
                reader2.Read();
                int ID_Answers2 = (int)reader2.GetValue(0);
                ///////////////////////////////////////////////////////////////////////////////////////////
                if (tb_new_Answers3.Text != "")
                {
                    Create_SQL_Command create_SQL_Command3 = new Create_SQL_Command(sqlString_Answers3);
                    SqlCommand sqlCommand3 = create_SQL_Command3.get_SQL_Command();
                    sqlCommand3.ExecuteNonQuery();

                    Create_SQL_Data_Reader create_SQL_Data_Reader3 = new Create_SQL_Data_Reader(sqlString_get_id_Answers3);
                    SqlDataReader reader3 = create_SQL_Data_Reader3.get_SQL_Data_Reader();
                    reader3.Read();
                    ID_Answers3 = (int)reader3.GetValue(0);

                    /////////////////////////////////////////////////////////////////////////////////////////////////
                    if (tb_new_Answers4.Text != "")
                    {
                        Create_SQL_Command create_SQL_Command4 = new Create_SQL_Command(sqlString_Answers4);
                        SqlCommand sqlCommand4 = create_SQL_Command4.get_SQL_Command();
                        sqlCommand4.ExecuteNonQuery();


                        Create_SQL_Data_Reader create_SQL_Data_Reader4 = new Create_SQL_Data_Reader(sqlString_get_id_Answers4);
                        SqlDataReader reader4 = create_SQL_Data_Reader4.get_SQL_Data_Reader();
                        reader4.Read();
                        ID_Answers4 = (int)reader4.GetValue(0);

                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        if (tb_new_Answers5.Text != "")
                        {
                            Create_SQL_Command create_SQL_Command5 = new Create_SQL_Command(sqlString_Answers5);
                            SqlCommand sqlCommand5 = create_SQL_Command5.get_SQL_Command();
                            sqlCommand5.ExecuteNonQuery();

                            Create_SQL_Data_Reader create_SQL_Data_Reader5 = new Create_SQL_Data_Reader(sqlString_get_id_Answers5);
                            SqlDataReader reader5 = create_SQL_Data_Reader5.get_SQL_Data_Reader();
                            reader5.Read();
                            ID_Answers5 = (int)reader5.GetValue(0);
                        }
                    }

                }
                    ////////////////////////////////////////////////////////////////////////////////////////////////////

                    string Topics = this.cb_select_Topics.Text;
                            string sqlString_get_id_Topics = "SELECT * FROM [Topics] WHERE name_subject=N'" + Topics + "';";
                            Create_SQL_Data_Reader create_SQL_Topics = new Create_SQL_Data_Reader(sqlString_get_id_Topics);
                            SqlDataReader reader_Topics = create_SQL_Topics.get_SQL_Data_Reader();
                            reader_Topics.Read();
                            int ID_Topics = (int)reader_Topics.GetValue(0);

                           // string sqlStringresponse = "select* from question where number_question = (select max(number_question) from question AND ID_Topics ='"+ID_Topics+"')";
                            string sqlStringresponse = "select MAX(number_question) From question WHERE ID_Topics='"+ID_Topics+"'";
                            Create_SQL_Data_Reader create_SQL_Data_Reader = new Create_SQL_Data_Reader(sqlStringresponse);
                            SqlDataReader reader = create_SQL_Data_Reader.get_SQL_Data_Reader();
                            reader.Read();
                            int _number_question = ((int)reader.GetValue(0)) + 1;
                        
                          
                            //создание вопроса в БД
                            string sqlString = "INSERT INTO [question] (question,ID_Answers1,ID_Answers2,ID_Answers3,ID_Answers4,ID_Answers5,ID_Topics,number_question) VALUES (N'" + tb_new_question.Text + "',N'" + ID_Answers1 + "','" + ID_Answers2 + "','" + ID_Answers3 + "','" + ID_Answers4 + "','" + ID_Answers5 + "','" + ID_Topics + "','" + _number_question + "');";
                            Create_SQL_Command create_SQL_Command_insert_question = new Create_SQL_Command(sqlString);
                            SqlCommand sqlCommand_insert_question = create_SQL_Command_insert_question.get_SQL_Command();
                            sqlCommand_insert_question.ExecuteNonQuery();
                            this.Close();
                        
                    
                
            }
            else { MessageBox.Show("Вы не указали правильный вариант"); }
        }

        private void Form_new_questions_Load(object sender, EventArgs e)
        {
            //вывод тематик
            string sqlString_get_Topics = "SELECT * FROM [Topics]";
            Get_DataTable get_DataTable = new Get_DataTable(sqlString_get_Topics);
            this.cb_select_Topics.DataSource = get_DataTable.get_DataTable();
            this.cb_select_Topics.DisplayMember = "name_subject";// столбец для отображения
            this.cb_select_Topics.ValueMember = "id";//столбец с id
            this.cb_select_Topics.SelectedIndex = -1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
