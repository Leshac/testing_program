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
    public partial class form_admin_result : Form
    {
        public form_admin_result()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {

            SqlConnection myConnection; Working_with_sql working_With_Sql = new Working_with_sql();
            myConnection = working_With_Sql.connect_to_the_database();




            //myConnection.Open();
            string sqlquery = "Select People_for_edu.LastName,People_for_edu.Name, People_for_edu.FatherName,Result_testing.data_testing,Result_testing.correct_questions,Result_testing.not_correct_questions,topics.name_subject from People_for_edu,Result_testing,Topics Where (People_for_edu.id=Result_testing.id_people_for_edu)AND( Topics.Id=Result_testing.id_topic_of_testing)";
            SqlCommand sqlCommand = new SqlCommand(sqlquery, myConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();


           

            List<string[]> data = new List<string[]>();
            
            while (reader.Read())
            {
                data.Add(new string[7]);
                
                
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();

                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();






            myConnection.Close();
           
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

        }




        private void form_admin_result_Load(object sender, EventArgs e)
        {
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
