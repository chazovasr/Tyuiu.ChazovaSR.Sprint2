﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChazovaSR.Sprint2.Task0.V0.Lib
{
    public class DataService : ISprint2Task0V0
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 1 == y;
            res[1] = x != y;
            res[2] = x < y;
            res[3] = x+2  > y;
            res[4] = x  <= y;
            res[5] = x + 3 >= y;

            return res;

        }
    }
}
