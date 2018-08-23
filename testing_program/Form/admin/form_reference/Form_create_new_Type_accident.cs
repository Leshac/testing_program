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
    public partial class Form_create_new_Type_accident : Form
    {
        public Form_create_new_Type_accident()
        {
            InitializeComponent();
        }

        private void Form_create_new_Type_accident_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_new_type_accident_Click(object sender, EventArgs e)
        {
            string create_type_accident_Query_sql = "INSERT INTO Type_accident (N_type,Name,code) VALUES (N'" + tb_number_type_accident.Text + "',N'" + tb_name_type_accident.Text + "',N'" + tb_key_type_accident.Text + "');";
            Create_SQL_Command create_SQL_Command = new Create_SQL_Command(create_type_accident_Query_sql);
            SqlCommand Command = create_SQL_Command.get_SQL_Command();
            Command.ExecuteNonQuery();
            this.Close();
        }
    }
}
