﻿using System;
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
    public partial class form_create_new_profession : Form
    {
        public form_create_new_profession()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string create_new_profession_Query_sql = "INSERT INTO Profession (Name) VALUES (N'" + tb_name.Text +  "');";
            Create_SQL_Command create_SQL_Command = new Create_SQL_Command(create_new_profession_Query_sql);
            SqlCommand Command = create_SQL_Command.get_SQL_Command();
            Command.ExecuteNonQuery();
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
