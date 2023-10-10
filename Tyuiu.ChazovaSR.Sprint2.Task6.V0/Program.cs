using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint2.Task6.V0.Lib;

namespace Tyuiu.ChazovaSR.Sprint2.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #2                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                    *");
            Console.WriteLine("* Задание #6                                              *");
            Console.WriteLine("* Вариант #0                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу, которая в зависимости от порядкового *");
            Console.WriteLine("*номера месяца (1, 2, …, 12) выводит на экран его         *");
            Console.WriteLine("*название (январь, февраль, …, декабрь).                  *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Введите номер месяца : ");
            int numMonth = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((numMonth < 1) || (numMonth > 12))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это месяц : " + ds.FindMonthName(numMonth);
            }



            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
