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
        const int ColumnCount=36;
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
            dgv_all_accident.Columns[10].Name = "Стаж работы общ";
            dgv_all_accident.Columns[11].Name = "Стаж работы по профессии при вып которой произошел НС";
            dgv_all_accident.Columns[12].Name = "Стаж работы в организации";
            dgv_all_accident.Columns[13].Name = "Время суток";
            dgv_all_accident.Columns[14].Name = "Время от начала смены";
            dgv_all_accident.Columns[15].Name = "График работы";
            dgv_all_accident.Columns[16].Name = "День недели НС";
            dgv_all_accident.Columns[17].Name = "Дата вводного инструктажа ";
            dgv_all_accident.Columns[18].Name = "Дата повторного (последнего) инструктажа";
            dgv_all_accident.Columns[19].Name = "Время после инстр-жа";
            dgv_all_accident.Columns[20].Name = "Дата проверки знаний";
            dgv_all_accident.Columns[21].Name = "Время после проверки знаний";
            dgv_all_accident.Columns[22].Name = "Стажировка";
            dgv_all_accident.Columns[23].Name = "Обучение по ОТ";
            dgv_all_accident.Columns[24].Name = "СредстаИндивидуальной Защиты";
            dgv_all_accident.Columns[25].Name = "Условия Труда";
            dgv_all_accident.Columns[26].Name = "СОУТ/АРМ (Дата)";
            dgv_all_accident.Columns[27].Name = "Опасные и вредные Производственные Факторы";
            dgv_all_accident.Columns[28].Name = "Доп. инфо";
            dgv_all_accident.Columns[29].Name = "Алкоголь";
            dgv_all_accident.Columns[30].Name = "Семья";
            dgv_all_accident.Columns[31].Name = "Образование";
            dgv_all_accident.Columns[32].Name = "Профессия";
            dgv_all_accident.Columns[33].Name = "Квалификация";
            dgv_all_accident.Columns[34].Name = "Предприятие";
            dgv_all_accident.Columns[35].Name = "ОКВЭД/отрасль";
        }

        private void Populate_dgv()
        {
            SqlConnection myConnection; Working_with_sql working_With_Sql = new Working_with_sql();
            myConnection = working_With_Sql.connect_to_the_database();

            string sqlquery = "SELECT"+
" CONCAT(People_for_edu.LastName, People_for_edu.Name, People_for_edu.FatherName) as ФИО," +

     "   seriuosness.Seriousness as [Тяжесть последствий]," +

      "  Datetime as [Дата происшествия]," +
      "  month as [Месяц НС]," +

      "  CONCAT(Type_accident.N_type, Type_accident.Name) as [Вид происшествия]," +

      "  test1 as [Причина]," +

      "  People_for_edu.Birthday as [Дата рождения]," +

      "  Age_on_accident as [Возраст на момент НС]," +

      "  Sex.[Name] as [Пол]," +

     "    Work.Date_enter as [Дата начала труд.Деят.]," +

      "  general_exp_on_accident as[Стаж работы общ]," +

      "  exp_on_profession_on_accident as [Стаж работы по профессии при вып которой произошел НС]," +

      "  exp_in_enterprise_on_accident as [Стаж работы в организации]," +

      "  Datetime as [Время суток]," +

      "  [Time_acc_work(in hours)] as [Время от начала смены]," +

      "  Shedule.Name as [График работы]," +

       " Dayweek as [День недели НС]," +

       " datesInstructions.Date_enter_inst as [Дата вводного инструктажа]," +

       " datesInstructions.Date_last_inst as [Дата повторного(последнего) инструктажа]," +

     "   datesInstructions.Time_after_instr as [Время после инстр-жа], " +

      "  datesInstructions.Date_last_check as [Дата проверки знаний]," +

      "  datesInstructions.Time_after_check as [Время после проверки знаний]," +

      "  Work.internship as [Стажировка]," +
      "  (SELECT COUNT(Instruct.id) From Instruct" +
           "  Join Info_education on Info_education.id_instruct=Instruct.id" +
           "  Where(Instruct.id_type_instruct= '5')AND(Info_education.id_human= test2.id_human) ) as [Обучение по ОТ]," +

       " test2.SIZ as [Средста Индивидуальной Защиты]," +

       " SOUT_ARM.UT as [Условия Труда]," +

      "  SOUT_ARM.Date_sout as[СОУТ/АРМ(Дата)]," +
      " (SELECT" +
                      "   STUFF((" +
                       "  SELECT ', '+ Name" +
                       "  from OVPF" +
                       "  left Join Workplace_OVPF on Workplace_OVPF.id_OVPF=OVPF.id" +
                       "  left Join Acc on acc.id_accident= Workplace_OVPF.id_acc" +

                       "  Where Workplace_OVPF.id_acc= test2.acc_id" +

                       "  order by Name" +

                       "  for XML path('')" +

                        " ),1,2,'' ) as ovpf_acc" +
                " FROM Workplace_OVPF cd" +
                " Where cd.id_acc=test2.acc_id" +
                " group by cd.id_acc) as [Опасные и вредные  Производственные Факторы]," +

       " People_for_edu.extra as [Доп.инфо]," +

      "  Alcohol as [Алкоголь]," +

       " Family.[Name] as [Семья]," +

       " Education.[Name] as [Образование]," +

       " Profession.[Name] as [Профессия], " +

       " Qualification.[Name] as [Квалификация]," +

      "  Enterprise.[Name] as [Предприятие]," +

       " CONCAT(OKVED.code_OKVED, OKVED.Name) as [ОКВЭД/отрасль]" +

       "  From" +
        " (SELECT* " +
         " From (" +
                " SELECT id_accident as acc_id, " +
                        " STUFF((" +
                        " SELECT ', '+ N_code" +
                        " from Code_reason" +
                        " left Join Codes_reason_in_accident on Codes_reason_in_accident.id_codes= Code_reason.id" +

                       "  left Join Acc on acc.id_accident= Codes_reason_in_accident.id_accident" +

                        " Where Codes_reason_in_accident.id_accident= cd.id_accident" +

                        " order by N_code" +

                        " for XML path('')" +

                        " ),1,2,'' ) as test1" +
               "  FROM Codes_reason_in_accident cd" +

"                 group by cd.id_accident) as test" +
"                 left JOIN Acc on acc.id_accident=test.acc_id" +

"         ) as test2" +
" left JOIN People_for_edu on People_for_edu.id=id_human" +
" JOIN seriuosness on seriuosness.id= id_seriousness" +
" JOIN Type_accident on Type_accident.id_type = test2.id_type" +
" JOIN Sex on sex.id= People_for_edu.id_sex" +
" JOIN datesInstructions on datesInstructions.id_hum= People_for_edu.id" +
" JOIN Work_actions   on Work_actions.id_work_human= People_for_edu.id" +
" JOIN Work   on Work.id = Work_actions.id_work" +
" LEFT JOIN Workplace on Workplace.id_people= People_for_edu.id" +
" LEFT JOIN SOUT_ARM on SOUT_ARM.id_SOUT= Workplace.id_sout" +



" JOIN Family on Family.id= People_for_edu.id_family" +
" JOIN Education on Education.id= People_for_edu.id_education" +
" JOIN Profession on Profession.id= People_for_edu.id_profession" +
" JOIN Qualification  on Qualification.id = People_for_edu.id_qualification" +
" JOIN Enterprise on Enterprise.id= Work.id_enterprise" +
" JOIN OKVED on OKVED.id= Enterprise.id_OKVED" +
" JOIN Shedule on Shedule.id= Work.id_work_schedule";  
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
                data[data.Count - 1][27] = reader[27].ToString();
                data[data.Count - 1][28] = reader[28].ToString();
                data[data.Count - 1][29] = reader[29].ToString();
                data[data.Count - 1][30] = reader[30].ToString();
                data[data.Count - 1][31] = reader[31].ToString();
                data[data.Count - 1][32] = reader[32].ToString();
                data[data.Count - 1][33] = reader[33].ToString();
                data[data.Count - 1][34] = reader[34].ToString();
                data[data.Count - 1][35] = reader[35].ToString();
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
