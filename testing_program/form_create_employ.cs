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
    public partial class form_create_employ : Form
    {
        public form_create_employ()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_new_employ_Click(object sender, EventArgs e)
        {
            
            string create_employ_Query_sql = "INSERT INTO employer (Surname,Name,Patronymic,Date_of_Birth) VALUES (N'"+ tb_Surname.Text +"',N'"+ tb_Name.Text + "',N'"+ tb_Patronymic.Text + "','"+ dt_Date_of_Birth.Value.Date + "');";
            Create_SQL_Command create_SQL_Command = new Create_SQL_Command(create_employ_Query_sql);
            SqlCommand Command = create_SQL_Command.get_SQL_Command();
            Command.ExecuteNonQuery();
            this.Close();




        }
    }
}
