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
    public partial class form_create_new_enterprise : Form
    {
        public form_create_new_enterprise()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_create_new_enterprise_Load(object sender, EventArgs e)
        {
            string sqlString_get_OKVED = "SELECT Full_OKVED=concat(code_OKVED,Name), id FROM OKVED";
            Get_DataTable get_DataTable = new Get_DataTable(sqlString_get_OKVED);
            this.cb_OKVED.DataSource = get_DataTable.get_DataTable();
            this.cb_OKVED.DisplayMember = "Full_OKVED";// столбец для отображения
            this.cb_OKVED.ValueMember = "id";//столбец с id
            this.cb_OKVED.SelectedIndex = -1;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string create_new_enterprise_query_sql = "INSERT INTO Enterprise (Name,id_OKVED) VALUES (N'" + tb_name.Text + "','" + this.cb_OKVED.SelectedValue + "'); ";
            Create_SQL_Command create_SQL_Command = new Create_SQL_Command(create_new_enterprise_query_sql);
            SqlCommand sqlCommand = create_SQL_Command.get_SQL_Command();
            sqlCommand.ExecuteNonQuery();
            this.Close();
        }

        private void btn_create_new_OKVED_Click(object sender, EventArgs e)
        {
            form_create_new_OKVED form_Create_New_OKVED = new form_create_new_OKVED();
            form_Create_New_OKVED.ShowDialog();
        }
    }
}
