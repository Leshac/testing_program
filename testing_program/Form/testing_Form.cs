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
    public partial class Form_CHOOSING_TESTS : Form
    {
        public Form_CHOOSING_TESTS()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {

            /* if (CB_testing_safety_engineering.Checked) { select_test_static.safety_engineering = true; }

             if (CB_testing_psychoemotional_state.Checked) { select_test_static.psychoemotional = true; } ;*/
            select_test_static.select_topics_test =Convert.ToUInt16( lb_topic.SelectedValue);
            this.Hide();
            /*FORM_survey_form survey_form = new FORM_survey_form();
            survey_form.ShowDialog();*/
            survey_form_ survey_form = new survey_form_();
            survey_form.ShowDialog();


            
        }

        private void CB_testing_safety_engineering_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form_CHOOSING_TESTS_Load(object sender, EventArgs e)
        {
            string sqlString_get_topic = "SELECT name_subject,id FROM topics";
            Get_DataTable get_DataTable = new Get_DataTable(sqlString_get_topic);
            this.lb_topic.DataSource = get_DataTable.get_DataTable();
            this.lb_topic.DisplayMember = "name_subject";// столбец для отображения
            this.lb_topic.ValueMember = "id";//столбец с id
            this.lb_topic.SelectedIndex = -1;
        }
    }
}
