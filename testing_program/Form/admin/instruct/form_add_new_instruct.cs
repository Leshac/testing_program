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
    public partial class form_add_new_instruct : Form
    {
        public form_add_new_instruct()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_type_instruct_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_type_instruct = "SELECT Name, id FROM Type_instruct";
            Get_DataTable get_DataTable_type_instruct = new Get_DataTable(sqlString_get_type_instruct);
            this.cb_type_instruct.DataSource = get_DataTable_type_instruct.get_DataTable();
            this.cb_type_instruct.DisplayMember = "Name";// столбец для отображения
            this.cb_type_instruct.ValueMember = "id";//столбец с id
            this.cb_type_instruct.SelectedIndex = -1;
            

        }

        private void btn_create_new_type_instruct_Click(object sender, EventArgs e)
        {
            form_create_new_type_instruct form_Create_New_Type_Instruct = new form_create_new_type_instruct();
            form_Create_New_Type_Instruct.ShowDialog();
        }

        private void cb_topic_instruct_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_topic_instruct = "SELECT Name, id FROM Topic_instruct";
            Get_DataTable get_DataTable_topic_instruct = new Get_DataTable(sqlString_get_topic_instruct);
            this.cb_topic_instruct.DataSource = get_DataTable_topic_instruct.get_DataTable();
            this.cb_topic_instruct.DisplayMember = "Name";// столбец для отображения
            this.cb_topic_instruct.ValueMember = "id";//столбец с id
            this.cb_topic_instruct.SelectedIndex = -1;

        }

        private void btn_create_new_topic_instruct_Click(object sender, EventArgs e)
        {
            form_create_new_topic_instruct form_Create_New_Topic_Instruct = new form_create_new_topic_instruct();
            form_Create_New_Topic_Instruct.ShowDialog();
        }

        private void cb_select_people_DropDown(object sender, EventArgs e)
        {
            
        }

        private void btn_create_new_people_for_edu_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_add_new_instruct_Click(object sender, EventArgs e)
        {

             string create_new_instruct_Query_sql = "INSERT INTO Instruct (id_type_instruct,id_topic_instruct,Date_instr) VALUES ('" + cb_type_instruct.SelectedValue + "','" + cb_topic_instruct.SelectedValue+ "','" +dt_date_Date_instr.Value.Date +"');";
             Create_SQL_Command create_SQL_Command = new Create_SQL_Command(create_new_instruct_Query_sql);
             SqlCommand Command = create_SQL_Command.get_SQL_Command();
             Command.ExecuteNonQuery();

             string get_lost_id_for_table_instruct = "select IDENT_CURRENT('Instruct')";
             Create_SQL_Command create_SQL_Command_get_lost_id_for_table_instruct = new Create_SQL_Command(get_lost_id_for_table_instruct);
             SqlCommand Command_get_lost_id = create_SQL_Command_get_lost_id_for_table_instruct.get_SQL_Command();
             SqlDataReader reader = Command_get_lost_id.ExecuteReader();
             long id_lost_instruct=0;
             while (reader.Read())
             {
                 id_lost_instruct = Convert.ToInt64(reader.GetValue(0));
             }
            
            for (int i = 0; i < clb_people_for_edu.Items.Count; i++)
            {
                if (clb_people_for_edu.GetItemChecked(i))
                {
                    clb_people_for_edu.SetSelected(i,true);
                    int index = (int)clb_people_for_edu.SelectedValue;

                    string create_new_info_education_Query_sql = "INSERT INTO Info_education (id_human,id_instruct) VALUES ('" + index + "','" + id_lost_instruct + "');";
                    Create_SQL_Command create_SQL_Command_info_education = new Create_SQL_Command(create_new_info_education_Query_sql);
                    SqlCommand Command_info_education = create_SQL_Command_info_education.get_SQL_Command();
                    Command_info_education.ExecuteNonQuery();
                    

                }
                
            }
            /* string create_new_info_education_Query_sql = "INSERT INTO Info_education (id_human,id_instruct) VALUES ('" + clb_people_for_edu.SelectedIndex + "','" + id_lost_instruct +  "');";
             Create_SQL_Command create_SQL_Command_info_education = new Create_SQL_Command(create_new_info_education_Query_sql);
             SqlCommand Command_info_education = create_SQL_Command_info_education.get_SQL_Command();
             Command_info_education.ExecuteNonQuery();*/
           
            this.Close();
        }

        private void cb_type_instruct_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void cb_type_instruct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void form_add_new_instruct_Load(object sender, EventArgs e)
        {
            string sqlString_get_people_for_edu = "SELECT FIO=CONCAT(LastName,Name,FatherName) , id FROM People_for_edu";
            Get_DataTable get_DataTable_people_for_edu = new Get_DataTable(sqlString_get_people_for_edu);
            this.clb_people_for_edu.DataSource = get_DataTable_people_for_edu.get_DataTable();
            this.clb_people_for_edu.DisplayMember = "FIO";// столбец для отображения
            this.clb_people_for_edu.ValueMember = "id";//столбец с id
            this.clb_people_for_edu.SelectedIndex = -1;
        }
    }
}
