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
    public partial class Form_output_of_all_incidents : Form
    {
        private DataGridView dgv_all_accident = new DataGridView();
        const int ColumnCount=27;
        public Form_output_of_all_incidents()
        {
            InitializeComponent();
            
            DGV_setup();
            Populate_dgv();
        }

        private void DGV_setup()
        {
            this.Controls.Add(dgv_all_accident);
            btn_exit.Location = new Point(SystemInformation.PrimaryMonitorSize.Width-80 , SystemInformation.PrimaryMonitorSize.Height-150);
            dgv_all_accident.ColumnCount = ColumnCount;
            dgv_all_accident.Name = "dgv_all_accident";
            dgv_all_accident.Location = new Point(8, 8);
            

            dgv_all_accident.Size = new Size(SystemInformation.PrimaryMonitorSize.Width-100, SystemInformation.PrimaryMonitorSize.Height-100);
            // dgv_all_accident.Size = new Size(1000, 700);
            //dgv_all_accident.AutoSize = true;
            // dgv_all_accident.ScrollBars = Both;


            dgv_all_accident.Columns[0].Name = "ФИО";
            dgv_all_accident.Columns[1].Name = "Тяжесть последствий";
            dgv_all_accident.Columns[2].Name = "Дата происшествия";
            dgv_all_accident.Columns[3].Name = "Месяц";
            dgv_all_accident.Columns[4].Name = "Вид происшествия";
            dgv_all_accident.Columns[5].Name = "Причина";
            dgv_all_accident.Columns[6].Name = "Дата рождения  ";
            dgv_all_accident.Columns[7].Name = "Возраст на момент НС";
            dgv_all_accident.Columns[8].Name = "Пол";
            dgv_all_accident.Columns[9].Name = "Дата начала труд. Деят.";
            dgv_all_accident.Columns[10].Name = "Время от начала смены";
            dgv_all_accident.Columns[11].Name = "День недели НС";
            dgv_all_accident.Columns[12].Name = "Дата повторного (последнего) инструктажа";
            dgv_all_accident.Columns[13].Name = "Время после инстр-жа";
            dgv_all_accident.Columns[14].Name = "Дата проверки знаний";
            dgv_all_accident.Columns[15].Name = "Время после проверки знаний";
            dgv_all_accident.Columns[16].Name = "Стажировка";
            dgv_all_accident.Columns[17].Name = "СИЗ";
            dgv_all_accident.Columns[18].Name = "УТ";
            dgv_all_accident.Columns[19].Name = "ОВПФ";
            dgv_all_accident.Columns[20].Name = "Алкоголь";
            dgv_all_accident.Columns[21].Name = "Семья";
            dgv_all_accident.Columns[22].Name = "Образование";
            dgv_all_accident.Columns[23].Name = "Профессия";
            dgv_all_accident.Columns[24].Name = "Квалификация";
            dgv_all_accident.Columns[25].Name = "Предприятие";
            dgv_all_accident.Columns[26].Name = "ОКВЭД/отрасль";
        }

        private void Populate_dgv()
        {
            SqlConnection myConnection; Working_with_sql working_With_Sql = new Working_with_sql();
            myConnection = working_With_Sql.connect_to_the_database();

            string sqlquery = "select "+
"CONCAT(People_for_edu.LastName, People_for_edu.Name, People_for_edu.FatherName),"+
" seriuosness.Seriousness,"+
 "acc.Datetime,"+
 "acc.month,"+
 "CONCAT(Type_accident.N_type, Type_accident.Name),"+
 "CONCAT(Code_reason.N_code, Code_reason.Name),"+ 
 "People_for_edu.Birthday," +
 "Acc.Age_on_accident," +
 "Sex.[Name]," +
"People_for_edu.Date_start_work," +
"acc.[Time_acc_work(in hours)]," +
"Acc.Dayweek," +
"datesInstructions.Date_last_inst," +
"datesInstructions.Time_after_instr," +
"datesInstructions.Date_last_check," +
"datesInstructions.Time_after_instr," +
"Work.internship," +
"Acc.SIZ," +
"CONCAT( SOUT_ARM.APFD, SOUT_ARM.Biological, SOUT_ARM.II,SOUT_ARM.IZ,SOUT_ARM.Khemical,SOUT_ARM.Microclimate,SOUT_ARM.N,SOUT_ARM.NI,SOUT_ARM.Noise,SOUT_ARM.SIZ,SOUT_ARM.SS,SOUT_ARM.T,SOUT_ARM.T,SOUT_ARM.UT,SOUT_ARM.UZ,SOUT_ARM.VL,SOUT_ARM.VO)," +
"OVPF.[Name]," +
"Acc.Alcohol," +
"Family.[Name]," +
"Education.[Name]," +
"Profession.[Name]," +
"Qualification.[Name]," +
"Enterprise.[Name]," +
"Enterprise.id_OKVED " +









"from People_for_edu left Join Sex on People_for_edu.id_sex = Sex.id " +

                    "left Join Education on People_for_edu.id_education = Education.id" +

                   " left Join Profession on People_for_edu.id_profession = Profession.id " +

                    "left Join Qualification on People_for_edu.id_qualification = Qualification.id " +

                  "  left Join Family on People_for_edu.id_family = Family.id " +

                   " left Join Acc on People_for_edu.id = Acc.id_human " +

                   " left Join seriuosness on seriuosness.id = Acc.id_seriousness " +

                   " left Join Type_accident on Type_accident.id_type = acc.id_type " +

                   " left Join Work_actions on Work_actions.id_work_human = People_for_edu.id " +

                   " left Join Work on Work.id = Work_actions.id_work " +

                   " left Join Enterprise on Enterprise.id = Work.id_enterprise " +

                  "  left Join Shedule on Shedule.id = Work.id_work_schedule " +

                   " left Join Conditions on Conditions.id = Work.id_conditions " +

                    "left Join OVPF on OVPF.id = Work.id_OVPF " +

                   " left Join Info_education on Info_education.id_human = People_for_edu.id " +

                  "  left Join Instruct on Instruct.id = Info_education.id_instruct " +

                   " left Join Type_instruct on Type_instruct.id = Instruct.id_type_instruct " +

                   " left Join Topic_instruct on Topic_instruct.id = Instruct.id_topic_instruct " +

                   " left Join Codes_reason_in_accident on Codes_reason_in_accident.id_accident = acc.id_accident " +

                   " left Join Code_reason on Code_reason.id = Codes_reason_in_accident.id_codes " +

                   " left Join datesInstructions on datesInstructions.id_hum = People_for_edu.id " +

                    "left join SOUT_ARM on SOUT_ARM.id_acc = Acc.id_accident ";  
            SqlCommand sqlCommand = new SqlCommand(sqlquery, myConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[ColumnCount]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();

                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();
                data[data.Count - 1][12] = reader[12].ToString();
                data[data.Count - 1][13] = reader[13].ToString();
                data[data.Count - 1][14] = reader[14].ToString();
                data[data.Count - 1][15] = reader[15].ToString();
                data[data.Count - 1][16] = reader[16].ToString();
                data[data.Count - 1][17] = reader[17].ToString();
                data[data.Count - 1][18] = reader[18].ToString();
                data[data.Count - 1][19] = reader[19].ToString();
                data[data.Count - 1][20] = reader[20].ToString();
                data[data.Count - 1][21] = reader[21].ToString();
                data[data.Count - 1][22] = reader[22].ToString();
                data[data.Count - 1][23] = reader[23].ToString();
                data[data.Count - 1][24] = reader[24].ToString();
                data[data.Count - 1][25] = reader[25].ToString();
                data[data.Count - 1][26] = reader[26].ToString();
            }
            reader.Close();






            myConnection.Close();

            foreach (string[] s in data)
            {
                dgv_all_accident.Rows.Add(s);
            }
        }

        


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
