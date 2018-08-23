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

            string sqlquery = "select CONCAT(People_for_edu.LastName, People_for_edu.Name, People_for_edu.FatherName),seriuosness.Seriousness ,CONCAT(Type_accident.N_type,Type_accident.Name),Acc.month, People_for_edu.Birthday, Acc.Age_on_accident, Sex.Name,Acc.Datetime,Acc.[Time_acc_work(in hours)] from People_for_edu, Acc,Type_accident,seriuosness, Sex where People_for_edu.id=Acc.id_human AND Type_accident.id_type=Acc.id_type AND Acc.id_seriousness=seriuosness.id AND Sex.id=People_for_edu.id_sex";
            SqlCommand sqlCommand = new SqlCommand(sqlquery, myConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[9]);


                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();

                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();

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
