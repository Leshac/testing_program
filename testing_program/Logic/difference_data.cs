using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace testing_program
{
   public static class difference_data
    {
        public static int diff_in_day(DateTime date1,DateTime date2)
        {
            System.TimeSpan diff = date2.Subtract(date1);
            int diff_int = diff.Days;
            return (diff_int);
        }
    }
}
