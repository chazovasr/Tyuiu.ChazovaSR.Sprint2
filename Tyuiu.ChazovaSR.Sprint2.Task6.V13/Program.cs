using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint2.Task6.V13.Lib;

namespace Tyuiu.ChazovaSR.Sprint2.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая вычисляет дату предыдущего дня              *");
            Console.WriteLine("* по заданным значениям пользователем (год, месяц, день).                 *");
            Console.WriteLine("* Заданный год является високосным.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите год : ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите месяц : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите день : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int res = Convert.ToInt32(ds.FindDateOfNextDay(g , m , n));
            Console.WriteLine($" Дата предыдущего дня: {res}");
            Console.ReadKey();
        }
    }
}
