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
    public partial class form_insert_reference_values : Form
    {
        public form_insert_reference_values()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_insert_reference_values_Load(object sender, EventArgs e)
        {
            string Get_correct_answers_for_good__Query_sql = "select Сorrect_answers_for_good_ from Reference_values;";
            Create_SQL_Command create_SQL_Command_get_Сorrect_answers_for_good_ = new Create_SQL_Command(Get_correct_answers_for_good__Query_sql);
            SqlCommand Command_get_correct_answers_for_good_ = create_SQL_Command_get_Сorrect_answers_for_good_.get_SQL_Command();
            SqlDataReader reader1 = Command_get_correct_answers_for_good_.ExecuteReader();
            
            while (reader1.Read())
            {
                tb_correct_answers_for_good_.Text = Convert.ToString(reader1.GetValue(0));
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string create_update_correct_answers_for_good__Query_sql = "UPDATE TOP(1) Reference_values SET Сorrect_answers_for_good_ = '"+tb_correct_answers_for_good_.Text+"'";
            Create_SQL_Command create_SQL_Command2 = new Create_SQL_Command(create_update_correct_answers_for_good__Query_sql);
            SqlCommand Command2 = create_SQL_Command2.get_SQL_Command();
            Command2.ExecuteNonQuery();
            this.Close();
        }
    }
}
