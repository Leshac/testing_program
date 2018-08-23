using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_program
{
       class Create_interface_form_question
    {
        int number_question;
        create_label create_question;
        Create_Radio_Button create_answers_1;
        Create_Radio_Button create_answers_2;
        Create_Radio_Button create_answers_3;
        Create_Radio_Button create_answers_4;
        Create_Radio_Button create_answers_5;

        public Create_interface_form_question(int _number_question, string sqlString)
        {
            number_question = _number_question;
            get_data_question get_Data_Question = new get_data_question(sqlString);
            string text_question = get_Data_Question.Text;


            /* line_break line_Break = new line_break();

             string text_question = line_Break.get_break_string(get_Data_Question.Text); */

            //create_label _create_question = new create_label("question", get_Data_Question.Text, 100, 25);
            create_label _create_question = new create_label("question", text_question, 50, 25);
            create_question = _create_question;

            // string sqlStringresponse = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers1  + "' ";
            string sqlStringresponse1 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers1 + "' ";
            string sqlStringresponse2 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers2 + "' ";
            string sqlStringresponse3 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers3 + "' ";
            string sqlStringresponse4 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers4 + "' ";
            string sqlStringresponse5 = "Select * From \"Answers\" Where id='" + get_Data_Question.ID_Answers5 + "' ";

            get_data_answers get_Data_Answers1 = new get_data_answers(sqlStringresponse1);
            get_data_answers get_Data_Answers2 = new get_data_answers(sqlStringresponse2);
            get_data_answers get_Data_Answers3 = new get_data_answers(sqlStringresponse3);
            get_data_answers get_Data_Answers4 = new get_data_answers(sqlStringresponse4);
            get_data_answers get_Data_Answers5 = new get_data_answers(sqlStringresponse5);


            string text_answers_1 = get_Data_Answers1.Text_Answer;
            string text_answers_2 = get_Data_Answers2.Text_Answer;
            string text_answers_3 = get_Data_Answers3.Text_Answer;
            string text_answers_4 = get_Data_Answers4.Text_Answer;
            string text_answers_5 = get_Data_Answers5.Text_Answer;

            Create_Radio_Button _create_answers_1 = new Create_Radio_Button("answers_1", text_answers_1, 123, 106);
            create_answers_1 = _create_answers_1;

            Create_Radio_Button _create_answers_2 = new Create_Radio_Button("answers_2", text_answers_2, 123, 156);
            create_answers_2 = _create_answers_2;
            if (text_answers_3 == "нет ответа                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ") {
                Create_Radio_Button _create_answers_3 = new Create_Radio_Button("answers_3", text_answers_3, -123, -206);
                create_answers_3 = _create_answers_3;
            }
            else {
                Create_Radio_Button _create_answers_3 = new Create_Radio_Button("answers_3", text_answers_3, 123, 206);
                create_answers_3 = _create_answers_3;
            }
            if (text_answers_4 == "нет ответа                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ")
            {
                Create_Radio_Button _create_answers_4 = new Create_Radio_Button("answers_4", text_answers_4, -123, -256);
                create_answers_4 = _create_answers_4;
            }
            else {
                Create_Radio_Button _create_answers_4 = new Create_Radio_Button("answers_4", text_answers_4, 123, 256);
                create_answers_4 = _create_answers_4;
            }
            if (text_answers_4 == "нет ответа                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ")
            {
                Create_Radio_Button _create_answers_5 = new Create_Radio_Button("answers_5", text_answers_5, -123, -306);
                create_answers_5 = _create_answers_5;
            }
            else {
                Create_Radio_Button _create_answers_5 = new Create_Radio_Button("answers_5", text_answers_5, 123, 306);
                create_answers_5 = _create_answers_5;
            }
        }

        public create_label get_create_question() {return (create_question);}
        public Create_Radio_Button get_create_answers_1() { return (create_answers_1); }
        public Create_Radio_Button get_create_answers_2() { return (create_answers_2); }
        public Create_Radio_Button get_create_answers_3() { return (create_answers_3); }
        public Create_Radio_Button get_create_answers_4() { return (create_answers_4); }
        public Create_Radio_Button get_create_answers_5() { return (create_answers_5); }
        
    }

}
