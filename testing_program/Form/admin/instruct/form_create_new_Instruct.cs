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
    public partial class form_create_new_Instruct : Form
    {
        public form_create_new_Instruct()
        {
            InitializeComponent();
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

        private void cb_topic_instruct_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_topic_instruct = "SELECT Name, id FROM Topic_instruct";
            Get_DataTable get_DataTable_topic_instruct = new Get_DataTable(sqlString_get_topic_instruct);
            this.cb_topic_instruct.DataSource = get_DataTable_topic_instruct.get_DataTable();
            this.cb_topic_instruct.DisplayMember = "Name";// столбец для отображения
            this.cb_topic_instruct.ValueMember = "id";//столбец с id
            this.cb_topic_instruct.SelectedIndex = -1;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string create_new_instruct_Query_sql = "INSERT INTO Instruct (id_type_instruct,id_topic_instruct,Date_instr) VALUES ('" + cb_type_instruct.SelectedValue + "','" + cb_topic_instruct.SelectedValue + "','" + dtp_Date_instr.Value.Date + "');";
            Create_SQL_Command create_SQL_Command = new Create_SQL_Command(create_new_instruct_Query_sql);
            SqlCommand Command = create_SQL_Command.get_SQL_Command();
            Command.ExecuteNonQuery();
            this.Close();
        }

        private void btn_create_new_type_instruct_Click(object sender, EventArgs e)
        {
            form_create_new_type_instruct form_Create_New_Type_Instruct = new form_create_new_type_instruct();
            form_Create_New_Type_Instruct.ShowDialog();
        }

        private void btn_create_new_topic_instruct_Click(object sender, EventArgs e)
        {
            form_create_new_topic_instruct form_Create_New_Topic_Instruct = new form_create_new_topic_instruct();
            form_Create_New_Topic_Instruct.ShowDialog();
        }
    }
}
