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
    public partial class FORM_survey_form : Form
    {
        public FORM_survey_form()
        {
            InitializeComponent();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FORM_survey_form_Load(object sender, EventArgs e)
        {
            // data_questions.number_questions  ++;
            // string sqlString = "Select * From \"question\" Where number_question='" + data_questions.number_questions+ "' "; 
            Random random = new Random();
            int number_questions = random.Next(1,10);
            string sqlString = "Select * From \"question\" Where number_question='" +number_questions+ "' ";
            Create_interface_form_question form_Question = new Create_interface_form_question(1, sqlString);
            

            this.Controls.Add(form_Question.get_create_question().create_label_in_form());
            this.Controls.Add(form_Question.get_create_answers_1().Create_Radio_Button_in_form());
            this.Controls.Add(form_Question.get_create_answers_2().Create_Radio_Button_in_form());
            this.Controls.Add(form_Question.get_create_answers_3().Create_Radio_Button_in_form());
            this.Controls.Add(form_Question.get_create_answers_4().Create_Radio_Button_in_form());
            this.Controls.Add(form_Question.get_create_answers_5().Create_Radio_Button_in_form());
            

        
            
        }

        private void reply_Click(object sender, EventArgs e)
        {

           // MessageBox.Show("проверка");
            this.Close();
            
            FORM_survey_form survey_form = new FORM_survey_form();
            survey_form.ShowDialog();
            this.Close();
        }
    }
}
