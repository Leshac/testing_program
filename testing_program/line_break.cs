using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_program
{
    class line_break
    {
        string stroka;
        string new_stroka;
        const int size_window=80;

        public string get_break_string (string _stroka)
        {
            stroka = _stroka;
            if (stroka.Length > size_window) {
                for (int i = 0; i < stroka.Length - 1; i += size_window)
                {
                    string part = ""; // часть строки
                    int index = 0, end = 0; // индекс куда вставлять "\n" и по сколько символов резать

                    if (stroka.Length < i + size_window)      // если это уже последний кусок и он < 80 
                    {                                  //
                        end = stroka.Length - i;     // то end = остаток символов
                    }
                    else
                    {
                        end = size_window;
                    }
                    part = stroka.Substring(i, end);    // вырезаем строку начиная с "i" и количеством end символов
                    
                    index = part.LastIndexOf(' ');   // ищет в вырезанной строке последнее вхождение пробела
                    new_stroka += part.Insert(index, "\n");    // вставляет "\n" на место последнего пробела*/
                }
            }
            return (new_stroka);
        }
        
    }

     
    
}
