﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChazovaSR.Sprint2.Task2.V8.Lib
{
    public class DataService : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x >= 3) && (x <= 5) && (y>=3) && (y <= 7))     ||    ((x >= 3) && (x<=5) && (y >= 11) && (y <= 11))           || ((x >= 6) && (x <= 6)&& (y>=5) && (y <= 11))                 || ((x >= 7)&& (x<=8)&&  (y>=5) && (y <= 6))      || ((x >= 7) && (x <= 8) && (y>=9) && (y <= 12))             || ((x >= 9) && (x <= 9)&& (y >= 2) && (y <= 12))          || ((x >= 10) && (x <=12 ) && (y >= 2) && (y <= 4))       || ((x >= 10) && (x <= 11) && (y >= 6) && (y <= 7)) ||        ((x >= 12) && (x <= 12) && (y >= 3) && (y <= 3)) ||    ((x >= 12) && (x <= 13) && (y >= 6) && (y <= 9)) || ((x >= 14) && (x <= 14) && (y >= 7) && (y <= 7)))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
