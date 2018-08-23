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
    public partial class Admin_panel : Form
    {
        public Admin_panel()
        {
            InitializeComponent();
        }

        private void Btn_new_user_Click(object sender, EventArgs e)
        {
            Form_new_user form_New_User = new Form_new_user();
            form_New_User.ShowDialog();
        }

        private void Btn_new_questions_Click(object sender, EventArgs e)
        {
            Form_new_questions form_New_Questions = new Form_new_questions();
            form_New_Questions.ShowDialog();
        }

       

        private void btn_show_result_Click(object sender, EventArgs e)
        {
            form_admin_result form_Admin_Result = new form_admin_result();
            form_Admin_Result.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_employ_Click(object sender, EventArgs e)
        {
            form_create_employ form_Create_Employ = new form_create_employ();
            form_Create_Employ.ShowDialog();


           




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form_create_topics form_Create_Topics = new form_create_topics();
            form_Create_Topics.ShowDialog();
        }

        private void btn_new_type_accident_Click(object sender, EventArgs e)
        {
            Form_create_new_Type_accident form_Create_New_Type_Accident = new Form_create_new_Type_accident();
            form_Create_New_Type_Accident.ShowDialog();
        }

        private void btn_create_Code_reason_Click(object sender, EventArgs e)
        {
            form_create_new_Code_reason form_Create_New_Code_Reason = new form_create_new_Code_reason();
            form_Create_New_Code_Reason.ShowDialog();
        }

        private void btn_create_OKVED_Click(object sender, EventArgs e)
        {
            form_create_new_OKVED form_Create_New_OKVED = new form_create_new_OKVED();
            form_Create_New_OKVED.ShowDialog();
        }

        private void btn_create_new_OVPF_Click(object sender, EventArgs e)
        {
            form_create_new_OVPF form_Create_New_OVPF = new form_create_new_OVPF();
            form_Create_New_OVPF.ShowDialog();
        }

        private void btn_create_new_seriuosness_Click(object sender, EventArgs e)
        {
            form_create_new_seriuosness form_Create_New_Seriuosness = new form_create_new_seriuosness();
            form_Create_New_Seriuosness.ShowDialog();
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

        private void btn_create_new_conditions_Click(object sender, EventArgs e)
        {
            form_create_new_conditions form_Create_New_Conditions = new form_create_new_conditions();
            form_Create_New_Conditions.ShowDialog();
        }

        private void btn_create_new_education_Click(object sender, EventArgs e)
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

        private void btn_create_new_accident_Click(object sender, EventArgs e)
        {
            form_create_new_accident_for_edu form_Create_New_Accident_For_Edu = new form_create_new_accident_for_edu();
            form_Create_New_Accident_For_Edu.ShowDialog();
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

        private void btn_create_new_Name_type_check_knowledge_Click(object sender, EventArgs e)
        {
            form_create_new_name_type_check_knowledge form_Create_New_Name_Type_Check_Knowledge = new form_create_new_name_type_check_knowledge();
            form_Create_New_Name_Type_Check_Knowledge.ShowDialog();
        }

        private void btn_create_new_instruct_Click(object sender, EventArgs e)
        {
            form_add_new_instruct form_Add_New_Instruct = new form_add_new_instruct();
            form_Add_New_Instruct.ShowDialog();
        }

        private void btn_create_new_instruct_not_people_Click(object sender, EventArgs e)
        {
            form_create_new_Instruct form_Create_New_Instruct = new form_create_new_Instruct();
            form_Create_New_Instruct.ShowDialog();
        }

        private void btn_insert_new_people_for_instruct_Click(object sender, EventArgs e)
        {
            form_insert_people_in_instruct form_Insert_People_In_Instruct = new form_insert_people_in_instruct();
            form_Insert_People_In_Instruct.ShowDialog();
        }

        private void btn_inset_new_info_people_in_work_Click(object sender, EventArgs e)
        {
            form_insert_people_in_work form_Insert_People_In_Work = new form_insert_people_in_work();
            form_Insert_People_In_Work.ShowDialog();
        }

        private void btn_create_new_people_for_edu_Click(object sender, EventArgs e)
        {
            form_create_new_people_for_edu form_Create_New_People_For_Edu = new form_create_new_people_for_edu();
            form_Create_New_People_For_Edu.ShowDialog();
        }

        private void btn_create_new_Info_check_knowledge_Click(object sender, EventArgs e)
        {
            form_create_new_check_knowledge form_Create_New_Check_Knowledge = new form_create_new_check_knowledge();
            form_Create_New_Check_Knowledge.ShowDialog();
        }

        private void btn_create_new_type_result_check_Click(object sender, EventArgs e)
        {
            form_create_new_type_result_check form_Create_New_Type_Result_Check = new form_create_new_type_result_check();
            form_Create_New_Type_Result_Check.ShowDialog();
        }

        private void btn_insert_reference_values_Click(object sender, EventArgs e)
        {
            form_insert_reference_values form_Insert_Reference_Values = new form_insert_reference_values();
            form_Insert_Reference_Values.ShowDialog();
        }
    }
}
