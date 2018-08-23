using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing_program
{
    class create_label
    {
        string Name;
        string Text;
        int Location_x_label;
        int Location_y_label;

        public create_label(string _Name,
                            string _Text,
                            int _Location_x_label,
                            int _Location_y_label)
        {
            Name = _Name;
            Text = _Text;
            Location_x_label = _Location_x_label;
            Location_y_label = _Location_y_label;
        }
        public Label create_label_in_form()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label.Location = new System.Drawing.Point(Location_x_label, Location_y_label);
            label.Name = Name;
            label.Size = new System.Drawing.Size(97, 36);
            label.Text = Text;
            return (label);
        }


    }
}
