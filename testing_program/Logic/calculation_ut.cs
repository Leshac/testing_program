using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing_program
{
    public static class calculation_ut
    {
        public static string calculate(string Khemical, string Microclimate, string Biological, string APFD, string Noise, string iz, string UZ, string VO, string vl, string ni, string II, string ss, string T, string N)
            {
            string ut = "";

            string[] sout = new string[] { Khemical, Microclimate, Biological, APFD, Noise, iz, UZ, VO, vl, ni, II, ss, T, N };
            int kol_1 = 0;
            int kol_2 = 0;
            int kol_3_1 = 0;
            int kol_3_2 = 0;
            int kol_3_3 = 0;
            int kol_3_4 = 0;
            int kol_4 = 0;

            for (int i = 0; i < sout.Length; i++)
            {
                if (string.Equals(sout[i], "1   ")) { kol_1++; }
                if (string.Equals(sout[i], "2   ")) { kol_2++; }
                if (string.Equals(sout[i], "3.1 ")) { kol_3_1++; }
                if (string.Equals(sout[i], "3.2 ")) { kol_3_2++; }
                if (string.Equals(sout[i], "3.3 ")) { kol_3_3++; }
                if (string.Equals(sout[i], "3.4 ")) { kol_3_4++; }
                if (string.Equals(sout[i], "4   ")) { kol_4++; }
            }

            // определение УТ 
            if (kol_4 < 1)
            {
                if (kol_3_4 < 2)
                {
                    if (kol_3_4 == 0)
                    {
                        if (kol_3_3 < 2)
                        {
                            if (kol_3_3 == 0)
                            {
                                if (kol_3_2 < 2)
                                {
                                    if (kol_3_2 == 0)
                                    {
                                        if (kol_3_1 < 3)
                                        {
                                            if (kol_3_1 == 0)
                                            {
                                                if (kol_2 < 1)
                                                {
                                                    if (kol_2 == 0)
                                                    {
                                                        if (kol_1 < 1)
                                                        {
                                                            MessageBox.Show("Что то пошло не так");
                                                        }
                                                        else
                                                        {
                                                            ut = "1";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        ut = "2";
                                                    }
                                                }
                                                else
                                                {
                                                    ut = "2";
                                                }
                                            }
                                            else
                                            {
                                                ut = "3.1";
                                            }
                                        }
                                        else
                                        {
                                            ut = "3.2";
                                        }
                                    }
                                    else
                                    {
                                        ut = "3.2";
                                    }
                                }
                                else
                                {
                                    ut = "3.3";
                                }
                            }
                            else
                            {
                                ut = "3.3";
                            }
                        }
                        else
                        {
                            ut = "3.4";
                        }
                    }
                    else
                    {
                        ut = "3.4";
                    }
                }
                else
                {
                    ut = "4";
                }
            }
            else
            {
                ut = "4";
            }
            return (ut);
        }
    }
}
