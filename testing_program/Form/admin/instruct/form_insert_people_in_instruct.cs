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
    public partial class form_insert_people_in_instruct : Form
    {
        public form_insert_people_in_instruct()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_insert_people_in_instruct_Load(object sender, EventArgs e)
        {
            string sqlString_get_people_for_edu = "SELECT FIO=CONCAT(LastName,Name,FatherName) , id FROM People_for_edu";
            Get_DataTable get_DataTable_people_for_edu = new Get_DataTable(sqlString_get_people_for_edu);
            this.clb_insert_people.DataSource = get_DataTable_people_for_edu.get_DataTable();
            this.clb_insert_people.DisplayMember = "FIO";// столбец для отображения
            this.clb_insert_people.ValueMember = "id";//столбец с id
            this.clb_insert_people.SelectedIndex = -1;

            string sqlString_get_instruct = "select full_instruct = CONCAT(Topic_instruct.Name,Instruct.Date_instr),Instruct.id From Instruct,Topic_instruct Where Instruct.id_topic_instruct=Topic_instruct.id";
            Get_DataTable get_DataTable_instruct = new Get_DataTable(sqlString_get_instruct);
            this.cb_instruct.DataSource = get_DataTable_instruct.get_DataTable();
            this.cb_instruct.DisplayMember = "full_instruct";// столбец для отображения
            this.cb_instruct.ValueMember = "Instruct.id";//столбец с id
            this.cb_instruct.SelectedIndex = -1;

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_insert_people.Items.Count; i++)
            {
                if (clb_insert_people.GetItemChecked(i))
                {
                    clb_insert_people.SetSelected(i, true);
                    int index = (int)clb_insert_people.SelectedValue;

                    string create_new_info_education_Query_sql = "INSERT INTO Info_education (id_human,id_instruct) VALUES ('" + index + "','" + cb_instruct.SelectedValue + "');";
                    Create_SQL_Command create_SQL_Command_info_education = new Create_SQL_Command(create_new_info_education_Query_sql);
                    SqlCommand Command_info_education = create_SQL_Command_info_education.get_SQL_Command();
                    Command_info_education.ExecuteNonQuery();
                    this.Close();

                }
                
            }

        }
    }
}
