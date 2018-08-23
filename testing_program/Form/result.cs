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
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
            label4.Text = Convert.ToString(static_test_result.current_question);
            label5.Text = Convert.ToString(static_test_result.correct_answer);
            label7.Text = Convert.ToString(static_test_result.not_correct_answer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
