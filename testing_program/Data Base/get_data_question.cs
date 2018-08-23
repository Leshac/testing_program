using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_program
{
    class get_data_question
    {
        public string Text;
        public int ID_Answers1;
        public int ID_Answers2;
        public int ID_Answers3;
        public int ID_Answers4;
        public int ID_Answers5;
        public int ID_Topics;
      public  string sqlString;

        public get_data_question(string _sqlString)
        {
            sqlString = _sqlString;
            get_text();
        }

        public void get_text()
        {
            Create_SQL_Data_Reader create_SQL_Data_Reader = new Create_SQL_Data_Reader(sqlString);
            SqlDataReader reader = create_SQL_Data_Reader.get_SQL_Data_Reader();
            while (reader.Read())
            {
                object id = reader.GetValue(0);
                Text = (string)reader.GetValue(1);
                ID_Answers1 = (int)reader.GetValue(2);
                ID_Answers2 = (int)reader.GetValue(3);
                ID_Answers3 = (int)reader.GetValue(4);
                ID_Answers4 = (int)reader.GetValue(5);
                ID_Answers5 = (int)reader.GetValue(6);
                ID_Topics = (int)reader.GetValue(7);
            }
        }
    }
}
