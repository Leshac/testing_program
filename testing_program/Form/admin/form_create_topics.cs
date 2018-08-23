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
    public partial class form_create_topics : Form
    {
        public form_create_topics()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string sqlquery = "INSERT INTO Topics (name_subject) VALUES (N'"+ tb_new_topics.Text+ "')"; 
            Create_SQL_Command create_SQL_Command = new Create_SQL_Command(sqlquery);
            SqlCommand create_new_topic = create_SQL_Command.get_SQL_Command();
            create_new_topic.ExecuteNonQuery();
            this.Close();
        }
    }
}
