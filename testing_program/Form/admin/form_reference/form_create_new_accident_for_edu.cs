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
    public partial class form_create_new_accident_for_edu : Form
    {
        public form_create_new_accident_for_edu()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_create_new_accident_for_edu_Load(object sender, EventArgs e)
        {
        }

        private void cb_education_DropDown(object sender, EventArgs e)
        {
           
        }

        private void cb_sex_DropDown(object sender, EventArgs e)
        {
           
        }

        private void cb_profession_DropDown(object sender, EventArgs e)
        {
            
        }

        private void cb_qualification_DropDown(object sender, EventArgs e)

        {
            
        }

        private void cb_family_DropDown(object sender, EventArgs e)
        {
            
        }

        private void cb_type_accident_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_type_accident = "SELECT  type_accident= CONCAT( N_type,Name,code),id_type FROM Type_accident";
            Get_DataTable get_DataTable_type_accident = new Get_DataTable(sqlString_get_type_accident);
            this.cb_type_accident.DataSource = get_DataTable_type_accident.get_DataTable();
            this.cb_type_accident.DisplayMember = "type_accident";// столбец для отображения
            this.cb_type_accident.ValueMember = "id_type";//столбец с id
            this.cb_type_accident.SelectedIndex = -1;
        }

        private void cb_enterprise_DropDown(object sender, EventArgs e)
        {
           
        }

        private void cb_work_schedule_DropDown(object sender, EventArgs e)
        {
          
        }

        private void cb_conditions_DropDown(object sender, EventArgs e)
        {
           
        }

        private void cb_OVPF_DropDown(object sender, EventArgs e)
        {
         
        }

        private void btn_create_education_Click(object sender, EventArgs e)
        {
            form_create_new_education form_Create_New_Education = new form_create_new_education();
            form_Create_New_Education.ShowDialog();
        }

        private void btn_create_new_profession_Click(object sender, EventArgs e)
        {
            form_create_new_profession form_Create_New_Profession = new form_create_new_profession();
            form_Create_New_Profession.ShowDialog();
        }

        private void btn_create_new_qualification_Click(object sender, EventArgs e)
        {
            form_create_new_qualification form_Create_New_Qualification = new form_create_new_qualification();
            form_Create_New_Qualification.ShowDialog();
        }

        private void btn_create_new_enterprise_Click(object sender, EventArgs e)
        {
            form_create_new_enterprise form_Create_New_Enterprise = new form_create_new_enterprise();
            form_Create_New_Enterprise.ShowDialog();
        }

        private void btn_create_new_shedule_Click(object sender, EventArgs e)
        {
            form_create_new_shedule form_Create_New_Shedule = new form_create_new_shedule();
            form_Create_New_Shedule.ShowDialog();
        }

        private void btn_create_new_OVPF_Click(object sender, EventArgs e)
        {
            form_create_new_OVPF form_Create_New_OVPF = new form_create_new_OVPF();
            form_Create_New_OVPF.ShowDialog();
        }

        private void btn_create_new_conditions_Click(object sender, EventArgs e)
        {
            form_create_new_conditions form_Create_New_Conditions = new form_create_new_conditions();
            form_Create_New_Conditions.ShowDialog();
        }

        private void btn_create_new_type_accident_Click(object sender, EventArgs e)
        {
            Form_create_new_Type_accident form_Create_New_Type_Accident = new Form_create_new_Type_accident();
            form_Create_New_Type_Accident.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string create_new_accident = "INSERT INTO acc (id_human, id_type, id_seriousness, Datetime, [Time_acc_work(in hours)], Dayweek, Age_on_accident, Alcohol,SIZ, month) VALUES ('" + cb_people_for_edu.SelectedValue + "','"+cb_type_accident.SelectedValue+"',N'" +cb_seriousness.SelectedValue + "',N'" + dt_Datetime_accident.Value.Date + "',N'" + tb_Time_acc_work.Text + "',N'" + tb_dayweek.Text+ "',N'" + tb_Age_on_accident.Text+ "',N'" + cb_Alcohol.Checked+ "',N'" + cb_SIZ.Checked+ "',N'" + tb_month.Text+ "')";
            Create_SQL_Command create_SQL_Command1 = new Create_SQL_Command(create_new_accident);
            SqlCommand Command1 = create_SQL_Command1.get_SQL_Command();
            Command1.ExecuteNonQuery();
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

        private void cb_seriousness_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_seriousness = "SELECT  Seriousness,id FROM seriuosness";
            Get_DataTable get_DataTable_seriousness = new Get_DataTable(sqlString_get_seriousness);
            this.cb_seriousness.DataSource = get_DataTable_seriousness.get_DataTable();
            this.cb_seriousness.DisplayMember = "Seriousness";// столбец для отображения
            this.cb_seriousness.ValueMember = "id";//столбец с id
            this.cb_seriousness.SelectedIndex = -1;
        }

        private void dt_Datetime_accident_CloseUp(object sender, EventArgs e)
        {
            string sqlString_get_Age_on_accident = "select datediff(mm, People_for_edu.Birthday , '"+dt_Datetime_accident.Value.Date+"' )/12 FROM People_for_edu";
            Create_SQL_Command create_SQL_Command_Age_on_accident = new Create_SQL_Command(sqlString_get_Age_on_accident);
            SqlCommand Command_get_Age_on_accident = create_SQL_Command_Age_on_accident.get_SQL_Command();
            SqlDataReader reader = Command_get_Age_on_accident.ExecuteReader();
            long Age_on_accident = 0;
            while (reader.Read())
            {
                Age_on_accident = Convert.ToInt64(reader.GetValue(0));
            }
            tb_Age_on_accident.Text =Convert.ToString(Age_on_accident);

            //заполнение поля время с начала рабочего дня
            string sqlString_get_time_acc_work = "SELECT DATEDIFF(MINUTE, Shedule.Time_start,'"+ dt_Datetime_accident.Value.TimeOfDay + "') FROM People_for_edu, Shedule, Work_actions, Work Where People_for_edu.id = '"+ cb_people_for_edu.SelectedValue + "'AND People_for_edu.id = Work_actions.id_work_human AND[Work].id = Work_actions.id_work AND Shedule.id =[Work].id_work_schedule";
            Create_SQL_Command create_SQL_Command_time_acc_work = new Create_SQL_Command(sqlString_get_time_acc_work);
            SqlCommand Command_get_time_acc_work = create_SQL_Command_time_acc_work.get_SQL_Command();
            SqlDataReader reader1 = Command_get_time_acc_work.ExecuteReader();
            long time_on_accident = 0;
            while (reader1.Read())
            {
                time_on_accident = Convert.ToInt64(reader1.GetValue(0));
            }
            tb_Time_acc_work.Text = Convert.ToString(time_on_accident);


            //заполнение поля день недели
            string sqlString_get_dayweek = "select DATEPART( weekday, '" + dt_Datetime_accident.Value.Date + "')";
            Create_SQL_Command create_SQL_Command_dayweek = new Create_SQL_Command(sqlString_get_dayweek);
            SqlCommand Command_get_dayweek = create_SQL_Command_dayweek.get_SQL_Command();
            SqlDataReader reader2 = Command_get_dayweek.ExecuteReader();
            long dayweek = 0;
            while (reader2.Read())
            {
                dayweek = Convert.ToInt64(reader2.GetValue(0));
            }
            tb_dayweek.Text = Convert.ToString(dayweek);

            //Заполнение поля месяц в году 
            string sqlString_get_month = "select DATEPART( month, '" + dt_Datetime_accident.Value.Date + "')";
            Create_SQL_Command create_SQL_Command_month = new Create_SQL_Command(sqlString_get_month);
            SqlCommand Command_get_month = create_SQL_Command_month.get_SQL_Command();
            SqlDataReader reader3 = Command_get_month.ExecuteReader();
            long month = 0;
            while (reader3.Read())
            {
                month = Convert.ToInt64(reader3.GetValue(0));
            }
            tb_month.Text = Convert.ToString(month);

        }
    }
}
