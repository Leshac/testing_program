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
    public partial class Form_Authorization : Form
    {
        
        public Form_Authorization()
        {
            InitializeComponent();
        }

        private void начатьТестированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string sqlQuery = "Select * FROM \"Authorization\"  where serial_number='" + tb_Serial_Number.Text + "' AND password = '" + tb_Password.Text + "'";
            Get_DataTable get_DataTable = new Get_DataTable(sqlQuery);
            get_DataTable.get_DataTable();
            try
            {
                if (get_DataTable.datatable.Rows[0][4].ToString() != "NULL")
                {
                    static_test_result.id_current = Convert.ToInt32(get_DataTable.datatable.Rows[0][4]);
                 this.Hide();
                    Form_CHOOSING_TESTS CHOOSING_TESTS = new Form_CHOOSING_TESTS();
                    CHOOSING_TESTS.ShowDialog();
                    this.Close();
                }
             }
            catch(System.IndexOutOfRangeException)

            {
                MessageBox.Show("Вы неправильно ввели серийный номер или пароль");
            }

            
        }

        private void Form_Authorization_Load(object sender, EventArgs e)
        {

        }

        private void Btn_admin_Click(object sender, EventArgs e)
        {
            string sqlQuery = "Select * FROM \"Authorization\"  where serial_number='" + tb_Serial_Number.Text + "' AND password = '" + tb_Password.Text + "' AND admin ='true'";

            update_DB update_DB = new update_DB();

            Get_DataTable get_DataTable = new Get_DataTable(sqlQuery);
            get_DataTable.get_DataTable();

            try
            {
                if (get_DataTable.datatable.Rows[0][0].ToString() != "NULL")
                {
                    this.Hide();
                    Admin_panel admin_form = new Admin_panel();
                    admin_form.ShowDialog();
                    this.Close();
                }
            }
            catch (System.IndexOutOfRangeException)

            {
                MessageBox.Show("У вас нет прав на вход в режиме администратора");
            }
        }
    }
}
