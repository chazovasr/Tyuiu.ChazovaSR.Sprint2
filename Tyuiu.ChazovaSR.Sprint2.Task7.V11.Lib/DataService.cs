﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChazovaSR.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (x <= 1 && (y <= 1) && ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1) && (y >= x))
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
