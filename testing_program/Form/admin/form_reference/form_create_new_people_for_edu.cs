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
    public partial class form_create_new_people_for_edu : Form
    {
        public form_create_new_people_for_edu()
        {
            InitializeComponent();
        }

        private void cb_sex_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_sex = "SELECT Name, id FROM Sex";
            Get_DataTable get_DataTable_sqlString_get_sex = new Get_DataTable(sqlString_get_sex);
            this.cb_sex.DataSource = get_DataTable_sqlString_get_sex.get_DataTable();
            this.cb_sex.DisplayMember = "Name";// столбец для отображения
            this.cb_sex.ValueMember = "id";//столбец с id
            this.cb_sex.SelectedIndex = -1;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void id_education_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_Education = "SELECT Name, id FROM Education";
            Get_DataTable get_DataTable_Education = new Get_DataTable(sqlString_get_Education);
            this.cb_education.DataSource = get_DataTable_Education.get_DataTable();
            this.cb_education.DisplayMember = "Name";// столбец для отображения
            this.cb_education.ValueMember = "id";//столбец с id
            this.cb_education.SelectedIndex = -1;
        }

        private void cb_profession_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_profession = "SELECT Name, id FROM Profession";
            Get_DataTable get_DataTable_profession = new Get_DataTable(sqlString_get_profession);
            this.cb_profession.DataSource = get_DataTable_profession.get_DataTable();
            this.cb_profession.DisplayMember = "Name";// столбец для отображения
            this.cb_profession.ValueMember = "id";//столбец с id
            this.cb_profession.SelectedIndex = -1;
        }

        private void cb_qualification_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_qualification = "SELECT Name, id FROM Qualification";
            Get_DataTable get_DataTable_qualification = new Get_DataTable(sqlString_get_qualification);
            this.cb_qualification.DataSource = get_DataTable_qualification.get_DataTable();
            this.cb_qualification.DisplayMember = "Name";// столбец для отображения
            this.cb_qualification.ValueMember = "id";//столбец с id
            this.cb_qualification.SelectedIndex = -1;
        }

        private void cb_family_DropDown(object sender, EventArgs e)
        {
            string sqlString_get_family = "SELECT Name, id FROM Family";
            Get_DataTable get_DataTable_family = new Get_DataTable(sqlString_get_family);
            this.cb_family.DataSource = get_DataTable_family.get_DataTable();
            this.cb_family.DisplayMember = "Name";// столбец для отображения
            this.cb_family.ValueMember = "id";//столбец с id
            this.cb_family.SelectedIndex = -1;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string create_new_People_for_edu_Query_sql = "INSERT INTO People_for_edu (LastName,Name,FatherName,Birthday,id_sex,id_education,id_profession,id_qualification,id_family,Date_start_work,extra,for_edu) VALUES ('" + tb_LastName.Text + "','" +tb_Name.Text+"','"+tb_father_name.Text+"','" + dtp_birthday.Value.Date +"','"+cb_sex.SelectedValue +"','"+ cb_education.SelectedValue+"','"+cb_profession.SelectedValue+"','"+cb_qualification.SelectedValue+"','"+cb_family.SelectedValue+"','"+dtp_date_start_work.Value.Date+"','"+rtb_extra.Text+"','"+ cb_for_edu.Checked+ "');";
            Create_SQL_Command create_SQL_Command = new Create_SQL_Command(create_new_People_for_edu_Query_sql);
            SqlCommand Command = create_SQL_Command.get_SQL_Command();
            Command.ExecuteNonQuery();
            this.Close();
        }
    }
}
