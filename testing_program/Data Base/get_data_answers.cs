using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_program
{
    class get_data_answers
    {
        string sqlStringresponse;
        public string Text_Answer;
        public object id_Answer;
        public object correct;

        public get_data_answers(string _sqlStringresponse)
        {
            sqlStringresponse = _sqlStringresponse;
            get_text();
        }
        public void get_text()
        {


            Create_SQL_Data_Reader create_SQL_Data_Reader = new Create_SQL_Data_Reader(sqlStringresponse);
            SqlDataReader reader = create_SQL_Data_Reader.get_SQL_Data_Reader();
            while (reader.Read())
            {
                id_Answer = reader.GetValue(0);
                Text_Answer = (string)reader.GetValue(1);
                correct = reader.GetValue(2);
            }

        }
    }
}
