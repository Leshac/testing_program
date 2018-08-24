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
        private DataGridView dgv_all_accident = new DataGridView();
        const int ColumnCount=10;
        public Form_output_of_all_incidents()
        {
            InitializeComponent();
            
            DGV_setup();
            Populate_dgv();
        }

        private void DGV_setup()
        {
            this.Controls.Add(dgv_all_accident);

            dgv_all_accident.ColumnCount = ColumnCount;
            dgv_all_accident.Name = "dgv_all_accident";
            dgv_all_accident.Location = new Point(8, 8);
            // dgv_all_accident.Size = new Size(500, 250);
            dgv_all_accident.AutoSize = true;


            dgv_all_accident.Columns[0].Name = "ФИО";
            dgv_all_accident.Columns[1].Name = "Тяжесть последствий";
            dgv_all_accident.Columns[2].Name = "Вид происшествия";
            dgv_all_accident.Columns[3].Name = "Месяц";
            dgv_all_accident.Columns[4].Name = "Дата рождения";
            dgv_all_accident.Columns[5].Name = "Возраст на момент НС";
            dgv_all_accident.Columns[6].Name = "Пол";
            dgv_all_accident.Columns[7].Name = "Дата происшествия";
            dgv_all_accident.Columns[8].Name = "Время от начала смены";
            dgv_all_accident.Columns[9].Name = "Причина происшествия";
        }

        private void Populate_dgv()
        {
            SqlConnection myConnection; Working_with_sql working_With_Sql = new Working_with_sql();
            myConnection = working_With_Sql.connect_to_the_database();

            string sqlquery = "select CONCAT(People_for_edu.LastName," +
                              " People_for_edu.Name, People_for_edu.FatherName)," +
                              "seriuosness.Seriousness, " +
                              "CONCAT(Type_accident.N_type,Type_accident.Name)," +
                              "Acc.month," +
                              " People_for_edu.Birthday," +
                              " Acc.Age_on_accident," +
                              " Sex.Name," +
                              "Acc.Datetime," +
                              "Acc.[Time_acc_work(in hours)]," +
                              "CONCAT(Code_reason.N_code, Code_reason.Name)"+

                              "from People_for_edu," +
                              "Acc," +
                              "Type_accident," +
                              "seriuosness," +
                              " Sex, " +
                              "Codes_reason_in_accident, "+
                              "Code_reason "+

                              "where People_for_edu.id=Acc.id_human AND" +
                              " Type_accident.id_type=Acc.id_type AND" +
                              " Acc.id_seriousness=seriuosness.id AND" +
                              " Sex.id=People_for_edu.id_sex AND"+
                              " Code_reason.id=Codes_reason_in_accident.id_codes AND"+
                              " Codes_reason_in_accident.id_accident = Acc.id_accident";
            SqlCommand sqlCommand = new SqlCommand(sqlquery, myConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[ColumnCount]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();

                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
            }
            reader.Close();






            myConnection.Close();

            foreach (string[] s in data)
            {
                dgv_all_accident.Rows.Add(s);
            }
        }

        


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
