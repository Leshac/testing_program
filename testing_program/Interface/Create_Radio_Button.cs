using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing_program
{
    class Create_Radio_Button
    {
        string Name;
        string Text;
        int Location_x_label;
        int Location_y_label;


        public Create_Radio_Button(string _Name,
                            string _Text,
                            int _Location_x_label,
                            int _Location_y_label)
        {
            Name = _Name;
            Text = _Text;
            Location_x_label = _Location_x_label;
            Location_y_label = _Location_y_label;
        }
        public RadioButton Create_Radio_Button_in_form()
        {
            RadioButton radioButton = new RadioButton();
            radioButton.AutoSize = true;
            radioButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            radioButton.Location = new System.Drawing.Point(Location_x_label, Location_y_label);
            radioButton.Name = Name;
            radioButton.Size = new System.Drawing.Size(136, 26);
            radioButton.TabIndex = 1;
            radioButton.TabStop = true;
            radioButton.Text = Text;
            radioButton.UseVisualStyleBackColor = true;
            
            return (radioButton);
        }
    }
}
