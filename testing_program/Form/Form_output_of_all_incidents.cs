using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing_program
{
    public partial class Form_output_of_all_incidents : Form
    {
        public Form_output_of_all_incidents()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
