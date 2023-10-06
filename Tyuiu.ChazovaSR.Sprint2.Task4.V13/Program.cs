using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint2.Task4.V13.Lib;

namespace Tyuiu.ChazovaSR.Sprint2.Task4.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #2                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                *");
            Console.WriteLine("* Задание #4                                              *");
            Console.WriteLine("* Вариант #13                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу, которая вычисляет требуемое значение *");
            Console.WriteLine("*с использованием тернарного оператора, где пользователь  *");
            Console.WriteLine("*вводит значение переменных x,y с клавиатуры, если        *");
            Console.WriteLine("*sqrt(x) * 3 > y * 2 - 20, то z= x + 10y - ( 1 - x ) иначе*");
            Console.WriteLine("*(x^2 + Cos(y^2) + 13) / (y^2)- Sin(y^2) + 9).            *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Введите значение переменной Х: ");
            int x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите значение переменной Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            double res = ds.Calculate(x, y);



            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}
