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
    public partial class form_input_data : Form
    {
        public form_input_data()
        {
            InitializeComponent();

        }

        private void btm_create_Click(object sender, EventArgs e)
        {
            if (test_double_people_for_edu.testing_copy(tb_LastName.Text, dtp_Birthday.Value.Date))
            {
                int id_human = insert_data_in_DB.Insert_in_table_people_for_edu(tb_LastName.Text, tb_Name.Text, tb_fatherName.Text, dtp_Birthday.Value.Date, cb_sex.SelectedValue, cb_leaning.SelectedValue, cb_prof.SelectedValue, cb_qualification.SelectedValue, cb_family.SelectedValue, rtb_EXTRA.Text, true);
                int id_work = insert_data_in_DB.insert_in_table_Work(cb_enterprice.SelectedValue, dtp_data_enter.Value.Date, Convert.ToDateTime(null), Convert.ToBoolean(null), cb_Shedule.SelectedValue, tb_ut.Text, cb_internship.Checked, Convert.ToDateTime(null), Convert.ToDateTime(null));
                int id_acc = insert_data_in_DB.insert_in_table_acc(id_human, cb_Type_accident.SelectedValue, cb_seriuosness.SelectedValue, get_data_time(), time_start(), Convert.ToString(dtp_date_acc.Value.DayOfWeek), Age_on_accident(), cb_alkogol.Checked, cb_siz.Checked, dtp_date_acc.Value.Month, get_general_exp(), id_work, get_enterprise_exp(), get_on_prof_exp());
                int id_work_action = insert_data_in_DB.insert_in_table_Work_action(id_human, id_work);
                insert_data_in_DB.insert_in_table_Codes_reason_in_accident(id_acc, lb_Code_reason);

                if (cb_learning_OT.Checked)
                {
                    object id_instr_ot = 5;
                    object id_ot_instr = 1004;
                    int id_instruct_ot = insert_data_in_DB.insert_in_table_Instruct(id_instr_ot, id_ot_instr, dtp_Date_first_inst.Value.Date);
                }

                if (chb_first_instr.Checked) //проверка необходимости добавления инструктажей
                {
                    int id_first_instruct = 0;
                    object id_first_instr = 3;
                    object id_topic_first_instr = 1004;
                    id_first_instruct = insert_data_in_DB.insert_in_table_Instruct(id_first_instr, id_topic_first_instr, dtp_Date_first_inst.Value.Date);
                    insert_data_in_DB.insert_in_table_Info_education(id_human, id_first_instruct);
                }

                if (chb_lost_instr.Checked)
                {
                    int id_last_instruct = 0;
                    object id_last_instr = 4;
                    object id_topic_last_instr = 1004;

                    id_last_instruct = insert_data_in_DB.insert_in_table_Instruct(id_last_instr, id_topic_last_instr, dtp_Date_last_inst.Value.Date);
                    insert_data_in_DB.insert_in_table_Info_education(id_human, id_last_instruct);
                }

                if (chb_check_knowledge.Checked)
                {
                    int id_Check_knowledge = 0;
                    object id_type_check = 3;
                    object id_Type_result_check = 1;

                    id_Check_knowledge = insert_data_in_DB.insert_in_table_Check_knowledge(id_type_check, dtp_Date_last_check.Value.Date, id_Type_result_check);
                    insert_data_in_DB.insert_in_table_Info_check_knowledge(id_human, id_Check_knowledge);
                }
                if (chb_insert_sout.Checked)
                {
                    int id_sout_arm = insert_data_in_DB.insert_in_table_SOUT_ARM(dtp_data_SOUT.Value.Date, true, cb_yt_him.Text, cb_yt_microclimat.Text, cb_yt_biology.Text, cb_yt_apfd.Text, cb_yt_hum.Text, cb_yt_iz.Text, cb_yt_yz.Text, cb_yt_vo.Text, cb_yt_vp.Text, cb_yt_nii.Text, cb_yt_ii.Text, cb_yt_ss.Text, cb_yt_t.Text, cb_yt_n.Text);
                    insert_data_in_DB.insert_in_table_Workplace(id_human, id_sout_arm);
                }

                insert_data_in_DB.insert_in_table_Workplace_OVPF(lb_ovpf, id_acc);
                if ((chb_lost_instr.Checked) & (chb_first_instr.Checked) & (chb_check_knowledge.Checked))
                {
                    int id_datesInstructions = insert_data_in_DB.insert_in_table_datesInstructions(id_human, dtp_Date_first_inst.Value.Date, dtp_Date_last_inst.Value.Date, dtp_Date_last_check.Value.Date, date_after_inst(), date_after_check());
                }
                else
                {
                    if ((chb_first_instr.Checked) & (chb_check_knowledge.Checked))
                    {
                        int id_datesInstructions = insert_data_in_DB.insert_in_table_datesInstructions(id_human, dtp_Date_first_inst.Value.Date, Convert.ToDateTime(null), dtp_Date_last_check.Value.Date, date_after_inst(), date_after_check());
                    }
                    else
                    {
                        if (chb_first_instr.Checked)
                        {
                            int id_datesInstructions = insert_data_in_DB.insert_in_table_datesInstructions(id_human, dtp_Date_first_inst.Value.Date, Convert.ToDateTime(null), Convert.ToDateTime(null), date_after_inst(), Convert.ToInt32(null));
                        }
                        else
                        {
                            if (chb_check_knowledge.Checked)
                            {
                                int id_datesInstructions = insert_data_in_DB.insert_in_table_datesInstructions(id_human, Convert.ToDateTime(null), Convert.ToDateTime(null), dtp_Date_last_check.Value.Date, Convert.ToInt32(null), date_after_check());
                            }
                        }
                    }

                }
                
                
            }
            this.Close();
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

        private void form_input_data_Load(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_code_reason(lb_Code_reason);
            cb_Drop_down.Drop_down_OVPF(lb_ovpf);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chb_first_instr_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_first_instr.Checked)
            {
                dtp_Date_first_inst.Enabled = true;
            }
            else
            {
                dtp_Date_first_inst.Enabled = false;
            }
        }

        private void chb_lost_instr_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_lost_instr.Checked)
            {
                dtp_Date_last_inst.Enabled = true;
            }
            else
            {
                dtp_Date_last_inst.Enabled = false;
            }
        }

        private void chb_check_knowledge_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_check_knowledge.Checked)
            {
                dtp_Date_last_check.Enabled = true;
            }
            else
            {
                dtp_Date_last_check.Enabled = false;
            }
        }

        private void cb_yt_him_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_him);
        }

        private void cb_yt_microclimat_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_microclimat);
        }

        private void cb_yt_biology_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_biology);
        }

        private void cb_yt_apfd_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_apfd);
        }

        private void cb_yt_hum_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_hum);
        }

        private void cb_yt_iz_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_iz);
        }

        private void cb_yt_yz_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_yz);
        }

        private void cb_yt_vo_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_vo);
        }

        private void cb_yt_vp_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_vp);
        }

        private void cb_yt_nii_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_nii);
        }

        private void cb_yt_ii_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_ii);
        }

        private void cb_yt_ss_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_ss);
        }

        private void cb_yt_t_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_t);
        }

        private void cb_yt_n_DropDown(object sender, EventArgs e)
        {
            cb_Drop_down.Drop_down_ut(cb_yt_n);
        }

        private void chb_insert_sout_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_insert_sout.Checked)
            {
                gb_UT.Enabled = true;
            }
            else
            {
                gb_UT.Enabled = false;
            }

        }

        private void btn_calculate_ut_Click(object sender, EventArgs e)
        {
           tb_ut.Text=calculation_ut.calculate(cb_yt_him.Text, cb_yt_microclimat.Text, cb_yt_biology.Text, cb_yt_apfd.Text, cb_yt_hum.Text, cb_yt_iz.Text, cb_yt_yz.Text, cb_yt_vo.Text, cb_yt_vp.Text, cb_yt_nii.Text, cb_yt_ii.Text, cb_yt_ss.Text, cb_yt_t.Text, cb_yt_n.Text);
        }

        private void dtp_date_acc_ValueChanged(object sender, EventArgs e)
        {
            tb_month.Text = $"{dtp_date_acc.Value.Month}";
            tb_Dayweek.Text = $"{dtp_date_acc.Value.DayOfWeek}";
            Age_on_accident();
        }

        private int Age_on_accident()
        {
            SqlConnection sqlConnection = new SqlConnection(ConectionSQL_string.sql_string);
            sqlConnection.Open();
                        
            string sql_quiry = $"select datediff(mm, '{dtp_Birthday.Value.Date}' , ' {dtp_date_acc.Value.Date}' )/12 FROM People_for_edu";

            SqlCommand sqlCommand = new SqlCommand(sql_quiry, sqlConnection);
            int age=Convert.ToInt32( sqlCommand.ExecuteScalar());

            return (age);
        }
        
        private void dtp_Birthday_ValueChanged(object sender, EventArgs e)
        {
            tb_Age_on_accident.Text = $"{Age_on_accident()}";
        }
        
        private void cb_Shedule_DropDownClosed(object sender, EventArgs e)
        {
           tb_time_ot_nach.Text= $"{time_start()}";
        }

        private int time_start()
        {
            int time_start = get_time_start.time_start(cb_Shedule.SelectedValue, Convert.ToString(dtp_Time_acc_work.Value.TimeOfDay));
            return (time_start);
        }

        private int get_general_exp()
        {
            int general_exp = sum__experience.experience(Convert.ToInt32(num_gen_old.Value), Convert.ToInt32(num_gen_month.Value), Convert.ToInt32(num_gen_day.Value));
            return (general_exp);
        }

        private int get_enterprise_exp()
        {
            int enterprise_exp = sum__experience.experience(Convert.ToInt32(num_enterprise_old.Value), Convert.ToInt32(num_enterprise_month.Value), Convert.ToInt32(num_enterprise_day.Value));
            return (enterprise_exp);
        }

        private int get_on_prof_exp()
        {
            int on_prof_exp = sum__experience.experience(Convert.ToInt32(num_on_prof_old.Value), Convert.ToInt32(num_on_prof_month.Value), Convert.ToInt32(num_on_prof_day.Value));
            return (on_prof_exp);
        }

        private void dtp_Date_last_inst_ValueChanged(object sender, EventArgs e)
        {
           
                tb_Time_after_instr.Text = $"{date_after_inst()}";
            
            
        }

        private int date_after_inst()
        {
            int after_int_day;
            if ((chb_lost_instr.Checked) & (chb_first_instr.Checked))
            {
                after_int_day = difference_data.diff_in_day(dtp_Date_last_inst.Value.Date, dtp_date_acc.Value.Date);
            }
            else
            {
                if (chb_first_instr.Checked)
                {
                    after_int_day = difference_data.diff_in_day(dtp_Date_first_inst.Value.Date, dtp_date_acc.Value.Date);
                }
                else
                {
                    after_int_day = 0;
                }
            }
            

            return (after_int_day);
        }

        private void dtp_Date_first_inst_ValueChanged(object sender, EventArgs e)
        {
            tb_Time_after_instr.Text = $"{date_after_inst()}";
        }

        private int date_after_check()
        {
           int time_after_check = difference_data.diff_in_day(dtp_Date_last_check.Value.Date, dtp_date_acc.Value.Date);
            return (time_after_check);
        }

        private void dtp_Date_last_check_ValueChanged(object sender, EventArgs e)
        {
            tb_TimeAfterInstr.Text = $"{date_after_check()}";
        }
        private DateTime get_data_time()
        {
            DateTime dateTime = dtp_date_acc.Value.Date + dtp_Time_acc_work.Value.TimeOfDay;
            return (dateTime);
        }

        private void btn_create_new_seriuosness_Click(object sender, EventArgs e)
        {
            form_create_new_seriuosness form_Create_New_Seriuosness = new form_create_new_seriuosness();
            form_Create_New_Seriuosness.ShowDialog();
        }

        private void btn_create_new_Type_accident_Click(object sender, EventArgs e)
        {
            Form_create_new_Type_accident form_Create_New_Type_Accident = new Form_create_new_Type_accident();
            form_Create_New_Type_Accident.ShowDialog();
        }

        private void btn_create_code_reason_Click(object sender, EventArgs e)
        {
            form_create_new_Code_reason form_Create_New_Code_Reason = new form_create_new_Code_reason();
            form_Create_New_Code_Reason.ShowDialog();
            cb_Drop_down.Drop_down_code_reason(lb_Code_reason);
        }

        private void btn_create_new_Shedule_Click(object sender, EventArgs e)
        {
            form_create_new_shedule form_Create_New_Shedule = new form_create_new_shedule();
            form_Create_New_Shedule.ShowDialog();
        }

        private void btn_create_new_prof_Click(object sender, EventArgs e)
        {
            form_create_new_profession form_Create_New_Profession = new form_create_new_profession();
            form_Create_New_Profession.ShowDialog();
        }

        private void btn_create_new_enterprise_Click(object sender, EventArgs e)
        {
            form_create_new_enterprise form_Create_New_Enterprise = new form_create_new_enterprise();
            form_Create_New_Enterprise.ShowDialog();
        }

        private void btn_create_new_qualification_Click(object sender, EventArgs e)
        {
            form_create_new_qualification form_Create_New_Qualification = new form_create_new_qualification();
            form_Create_New_Qualification.ShowDialog();
        }

        private void btn_create_new_education_Click(object sender, EventArgs e)
        {
            form_create_new_education form_Create_New_Education = new form_create_new_education();
            form_Create_New_Education.ShowDialog();
        }

        private void btn_create_new_OVPF_Click(object sender, EventArgs e)
        {
            form_create_new_OVPF form_Create_New_OVPF = new form_create_new_OVPF();
            form_Create_New_OVPF.ShowDialog();
            cb_Drop_down.Drop_down_OVPF(lb_ovpf);
        }
    }
}
