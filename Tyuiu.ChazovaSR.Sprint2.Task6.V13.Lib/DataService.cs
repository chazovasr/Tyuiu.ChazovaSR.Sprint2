using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ChazovaSR.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public double FindDateOfNextDay(int g, int m, int n)
        {
            int[] months = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            switch (n)
            {
                case 1:
                    m -= 1;
                    if (m == 0)
                    {
                        m = 12;
                        g -= 1;
                    }
                    n = months[n - 1];
                    break;
                default:
                    n -= 1;
                    break;
            }
            int res = Convert.ToInt32($"{g}{m}{n}");
            return res;
        }
    }
}
