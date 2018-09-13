using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing_program
{
    public partial class form_input_data : Form
    {
        public form_input_data()
        {
            InitializeComponent();

        }

        private void btm_create_Click(object sender, EventArgs e)
        {
            int id_human = insert_data_in_DB.Insert_in_table_people_for_edu(tb_LastName.Text, tb_Name.Text, tb_fatherName.Text, dtp_Birthday.Value.Date, cb_sex.SelectedValue, cb_leaning.SelectedValue, cb_prof.SelectedValue, cb_qualification.SelectedValue, cb_family.SelectedValue, rtb_EXTRA.Text, true);
            int id_work= insert_data_in_DB.insert_in_table_Work(cb_enterprice.SelectedValue, dtp_data_enter.Value.Date,Convert.ToDateTime(null), Convert.ToBoolean(null),cb_Shedule.SelectedValue,tb_ut.Text,cb_internship.Checked, Convert.ToDateTime(null), Convert.ToDateTime(null));
            int id_acc = insert_data_in_DB.insert_in_table_acc(id_human, cb_Type_accident.SelectedValue, cb_seriuosness.SelectedValue, dtp_date_acc.Value.Date, Convert.ToInt32(tb_time_ot_nach.Text), Convert.ToInt32(tb_Dayweek.Text), Convert.ToInt32(tb_Age_on_accident.Text), cb_alkogol.Checked, cb_siz.Checked, Convert.ToInt32(tb_month.Text), Convert.ToInt32(tb_general_exp.Text), id_work, Convert.ToInt32(tb_exp_in_enterprise.Text), Convert.ToInt32(tb_exp_on_profession.Text));
        }

        private void cb_sex_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_cb_sex(cb_sex);
        }

        private void cb_leaning_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_education(cb_leaning);
        }

        private void cb_prof_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_profession(cb_prof);
        }

        private void cb_qualification_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_qualification(cb_qualification);
        }

        private void cb_family_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_family(cb_family);
        }

        private void cb_Shedule_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_shedule(cb_Shedule);
        }

        private void cb_enterprice_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_enterprise(cb_enterprice);
        }

        private void cb_seriuosness_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_seriousness(cb_seriuosness);
        }

        private void cb_Type_accident_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_type_accident(cb_Type_accident);
        }
    }
}
