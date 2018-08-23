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
    public partial class form_insert_people_in_work : Form
    {
        public form_insert_people_in_work()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_people_for_edu_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_people_for_edu = "SELECT  FIO=CONCAT(LastName,Name,FatherName),id FROM People_for_edu";
            Get_DataTable get_DataTable_people_for_edu = new Get_DataTable(sqlString_get_people_for_edu);
            this.cb_people_for_edu.DataSource = get_DataTable_people_for_edu.get_DataTable();
            this.cb_people_for_edu.DisplayMember = "FIO";// столбец для отображения
            this.cb_people_for_edu.ValueMember = "id";//столбец с id
            this.cb_people_for_edu.SelectedIndex = -1;
        }

        private void cb_enterprise_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_enterprise = "SELECT  Name,id FROM Enterprise";
            Get_DataTable get_DataTable_enterprise = new Get_DataTable(sqlString_get_enterprise);
            this.cb_enterprise.DataSource = get_DataTable_enterprise.get_DataTable();
            this.cb_enterprise.DisplayMember = "Name";// столбец для отображения
            this.cb_enterprise.ValueMember = "id";//столбец с id
            this.cb_enterprise.SelectedIndex = -1;
        }

        private void cb_shedule_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_work_schedule = "SELECT  Name,id FROM Shedule";
            Get_DataTable get_DataTable_work_schedule = new Get_DataTable(sqlString_get_work_schedule);
            this.cb_shedule.DataSource = get_DataTable_work_schedule.get_DataTable();
            this.cb_shedule.DisplayMember = "Name";// столбец для отображения
            this.cb_shedule.ValueMember = "id";//столбец с id
            this.cb_shedule.SelectedIndex = -1;
        }

        private void cb_conditions_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_work_conditions = "SELECT Conditions_FULL= CONCAT( code_conditions,Name),id FROM Conditions";
            Get_DataTable get_DataTable_work_conditions = new Get_DataTable(sqlString_get_work_conditions);
            this.cb_conditions.DataSource = get_DataTable_work_conditions.get_DataTable();
            this.cb_conditions.DisplayMember = "Conditions_FULL";// столбец для отображения
            this.cb_conditions.ValueMember = "id";//столбец с id
            this.cb_conditions.SelectedIndex = -1;
        }

        private void cb_OVPF_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_work_OVPF = "SELECT OVPF_FULL= CONCAT( code_factor,Name),id FROM OVPF";
            Get_DataTable get_DataTable_work_OVPF = new Get_DataTable(sqlString_get_work_OVPF);
            this.cb_OVPF.DataSource = get_DataTable_work_OVPF.get_DataTable();
            this.cb_OVPF.DisplayMember = "OVPF_FULL";// столбец для отображения
            this.cb_OVPF.ValueMember = "id";//столбец с id
            this.cb_OVPF.SelectedIndex = -1;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if ( cb_remove.Checked  )
            {
                string create_new_work_Query_sql = "INSERT INTO Work (id_enterprise,Date_enter,Date_remove,work_on_prof,id_work_schedule,id_conditions,internship,Date_start_internship,Date_end_internship,id_OVPF, [SOUT/ARM]) VALUES ('" + cb_enterprise.SelectedValue + "','" + dtp_date_enter.Value.Date + "','" + dtp_date_remove.Value.Date + "','" + cb_work_on_prof.Checked + "','" + cb_shedule.SelectedValue + "','" + cb_conditions.SelectedValue + "','" + cb_internship.Checked + "','" + dtp_date_start_internship.Value.Date + "','" + dtp_date_end_internship.Value.Date + "','" + cb_OVPF.SelectedValue + "','" + tb_SOUT_ARM.Text + "');";
                Create_SQL_Command create_SQL_Command = new Create_SQL_Command(create_new_work_Query_sql);
                SqlCommand Command = create_SQL_Command.get_SQL_Command();
                Command.ExecuteNonQuery();

                string get_lost_id_for_table_work = "select IDENT_CURRENT('Work')";
                Create_SQL_Command create_SQL_Command_get_lost_id_for_table_work = new Create_SQL_Command(get_lost_id_for_table_work);
                SqlCommand Command_get_lost_id = create_SQL_Command_get_lost_id_for_table_work.get_SQL_Command();
                SqlDataReader reader = Command_get_lost_id.ExecuteReader();
                long id_lost_work = 0;
                while (reader.Read())
                {
                    id_lost_work = Convert.ToInt64(reader.GetValue(0));
                }

                string create_new_Work_actions_Query_sql = "INSERT INTO Work_actions (id_work_human,id_work) VALUES ('" + cb_people_for_edu.SelectedValue + "','" + id_lost_work + "');";
                Create_SQL_Command create_SQL_Command_Work_actions = new Create_SQL_Command(create_new_Work_actions_Query_sql);
                SqlCommand Command_Work_actions = create_SQL_Command_Work_actions.get_SQL_Command();
                Command_Work_actions.ExecuteNonQuery();
            }
            if (cb_remove.Checked == false) {
                string create_new_work_Query_sql = "INSERT INTO Work (id_enterprise,Date_enter,work_on_prof,id_work_schedule,id_conditions,internship,Date_start_internship,Date_end_internship,id_OVPF, [SOUT/ARM]) VALUES ('" + cb_enterprise.SelectedValue + "','" + dtp_date_enter.Value.Date + "','"  + cb_work_on_prof.Checked + "','" + cb_shedule.SelectedValue + "','" + cb_conditions.SelectedValue + "','" + cb_internship.Checked + "','" + dtp_date_start_internship.Value.Date + "','" + dtp_date_end_internship.Value.Date + "','" + cb_OVPF.SelectedValue + "','" + tb_SOUT_ARM.Text + "');";
                Create_SQL_Command create_SQL_Command = new Create_SQL_Command(create_new_work_Query_sql);
                SqlCommand Command = create_SQL_Command.get_SQL_Command();
                Command.ExecuteNonQuery();

                string get_lost_id_for_table_work = "select IDENT_CURRENT('Work')";
                Create_SQL_Command create_SQL_Command_get_lost_id_for_table_work = new Create_SQL_Command(get_lost_id_for_table_work);
                SqlCommand Command_get_lost_id = create_SQL_Command_get_lost_id_for_table_work.get_SQL_Command();
                SqlDataReader reader = Command_get_lost_id.ExecuteReader();
                long id_lost_work = 0;
                while (reader.Read())
                {
                    id_lost_work = Convert.ToInt64(reader.GetValue(0));
                }

                string create_new_Work_actions_Query_sql = "INSERT INTO Work_actions (id_work_human,id_work) VALUES ('" + cb_people_for_edu.SelectedValue + "','" + id_lost_work + "');";
                Create_SQL_Command create_SQL_Command_Work_actions = new Create_SQL_Command(create_new_Work_actions_Query_sql);
                SqlCommand Command_Work_actions = create_SQL_Command_Work_actions.get_SQL_Command();
                Command_Work_actions.ExecuteNonQuery();

                //заполнение поля дата начала трудовой деятельности
                string get_date_start_work = "select  min(Work.Date_enter)  from Work, Work_actions  where Work_actions.id_work_human='"+cb_people_for_edu.SelectedValue+"'AND Work.id=Work_actions.id_work";
                Create_SQL_Command create_SQL_Command_get_date_start_work = new Create_SQL_Command(get_date_start_work);
                SqlCommand Command_get_date_start_work = create_SQL_Command_get_date_start_work.get_SQL_Command();
                SqlDataReader reader2 = Command_get_date_start_work.ExecuteReader();
                DateTime date_start_work=new DateTime(1800,01,01,01,01,01);
                while (reader2.Read())
                    
                {
                    date_start_work = Convert.ToDateTime(reader2.GetValue(0));
                }
                string set_date_start_work = "UPDATE TOP(1) People_for_edu SET Date_start_work = '" + date_start_work + "' where People_for_edu.id='"+ cb_people_for_edu .SelectedValue+ "'";
                Create_SQL_Command create_SQL_Command_date_start_work = new Create_SQL_Command(set_date_start_work);
                SqlCommand Command_date_start_work = create_SQL_Command_date_start_work.get_SQL_Command();
                Command_date_start_work.ExecuteNonQuery();

            }
           
            this.Close();
        }
    }
}
