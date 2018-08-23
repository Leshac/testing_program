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
    public partial class Form_output_of_all_incidents : Form
    {
        public Form_output_of_all_incidents()
        {
            InitializeComponent();
            Load_Data();
        }
        public void Load_Data()
        {
            SqlConnection myConnection; Working_with_sql working_With_Sql = new Working_with_sql();
            myConnection = working_With_Sql.connect_to_the_database();

            string sqlquery = "Select People_for_edu.LastName from People_for_edu";
            SqlCommand sqlCommand = new SqlCommand(sqlquery, myConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);


                data[data.Count - 1][0] = reader[0].ToString();
                /*data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();

                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();*/
            }
            reader.Close();






            myConnection.Close();

            foreach (string[] s in data)
            {
                DGV_all_incidents.Rows.Add(s);
            }

        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
