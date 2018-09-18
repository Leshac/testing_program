using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_program
{
   public static class sum__experience
    {
        public static int experience(int old,int month, int day)
        {
            int experience_in_day=old*365+month*12+day;
            return (experience_in_day);
        }
    }
}
