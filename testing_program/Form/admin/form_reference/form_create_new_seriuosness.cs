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
    public partial class form_create_new_seriuosness : Form
    {
        public form_create_new_seriuosness()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string create_new_seriuosness_query_sql = "INSERT INTO seriuosness (Seriousness,[group]) VALUES (N'" + tb_name.Text + "','" + chb_group.Checked + "'); ";
            Create_SQL_Command create_SQL_Command = new Create_SQL_Command(create_new_seriuosness_query_sql);
            SqlCommand sqlCommand = create_SQL_Command.get_SQL_Command();
            sqlCommand.ExecuteNonQuery();
            this.Close();
        }
    }
}
