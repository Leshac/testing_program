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
    public partial class form_create_new_check_knowledge : Form
    {
        public form_create_new_check_knowledge()
        {
            InitializeComponent();
        }

        private void cb_id_people_for_edu_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_people_for_edu = "SELECT  FIO=CONCAT(LastName,Name,FatherName),id FROM People_for_edu";
            Get_DataTable get_DataTable_people_for_edu = new Get_DataTable(sqlString_get_people_for_edu);
            this.cb_id_people_for_edu.DataSource = get_DataTable_people_for_edu.get_DataTable();
            this.cb_id_people_for_edu.DisplayMember = "FIO";// столбец для отображения
            this.cb_id_people_for_edu.ValueMember = "id";//столбец с id
            this.cb_id_people_for_edu.SelectedIndex = -1;
        }

        private void cb_id_type_check_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_type_check = "SELECT  Name,id FROM Name_type_check_knowledge";
            Get_DataTable get_DataTable_type_check = new Get_DataTable(sqlString_get_type_check);
            this.cb_id_type_check.DataSource = get_DataTable_type_check.get_DataTable();
            this.cb_id_type_check.DisplayMember = "Name";// столбец для отображения
            this.cb_id_type_check.ValueMember = "id";//столбец с id
            this.cb_id_type_check.SelectedIndex = -1;
        }

        private void cb_id_type_result_check_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_type_result_check = "SELECT  Name,id FROM Type_result_check";
            Get_DataTable get_DataTable_type_result_check = new Get_DataTable(sqlString_get_type_result_check);
            this.cb_id_type_result_check.DataSource = get_DataTable_type_result_check.get_DataTable();
            this.cb_id_type_result_check.DisplayMember = "Name";// столбец для отображения
            this.cb_id_type_result_check.ValueMember = "id";//столбец с id
            this.cb_id_type_result_check.SelectedIndex = -1;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string create_new_Check_knowledge_Query_sql = "INSERT INTO Check_knowledge (id_type_check,Date_check,id_type_result_check) VALUES ('" + cb_id_type_check.SelectedValue + "','" + dtp_date_check.Value.Date + "','" + cb_id_type_result_check.SelectedValue + "');";
            Create_SQL_Command create_SQL_Command1 = new Create_SQL_Command(create_new_Check_knowledge_Query_sql);
            SqlCommand Command = create_SQL_Command1.get_SQL_Command();
            Command.ExecuteNonQuery();

            string get_lost_id_for_table_Check_knowledge = "select IDENT_CURRENT('Check_knowledge')";
            Create_SQL_Command create_SQL_Command_get_lost_id_for_table_Check_knowledge = new Create_SQL_Command(get_lost_id_for_table_Check_knowledge);
            SqlCommand Command_get_lost_id = create_SQL_Command_get_lost_id_for_table_Check_knowledge.get_SQL_Command();
            SqlDataReader reader1 = Command_get_lost_id.ExecuteReader();
            long id_lost_work = 0;
            while (reader1.Read())
            {
                id_lost_work = Convert.ToInt64(reader1.GetValue(0));
            }

            string create_new_Check_Info_check_knowledge_Query_sql = "INSERT INTO Info_check_knowledge (id_human,id_check) VALUES ('" + cb_id_people_for_edu.SelectedValue + "','" + id_lost_work + "');";
            Create_SQL_Command create_SQL_Command2 = new Create_SQL_Command(create_new_Check_Info_check_knowledge_Query_sql);
            SqlCommand Command2 = create_SQL_Command2.get_SQL_Command();
            Command2.ExecuteNonQuery();
            this.Close();

        }
    }
}
