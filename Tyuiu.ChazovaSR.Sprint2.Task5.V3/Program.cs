using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint2.Task5.V3.Lib;

namespace Tyuiu.ChazovaSR.Sprint2.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #2                                               *");
            Console.WriteLine("* Тема: Оператор switch                                   *");
            Console.WriteLine("* Задание #5                                              *");
            Console.WriteLine("* Вариант #3                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу, которая в зависимости от порядкового *");
            Console.WriteLine("*номера дня недели (1, 2, …, 7) выводит на экран его      *");
            Console.WriteLine("*название (понедельник, вторник, …, воскресенье).         *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Введите номер дня недели : ");
            int numDay = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((numDay < 1) || (numDay > 7))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это день недели: " + ds.FindDayName(numDay);
            }



            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
