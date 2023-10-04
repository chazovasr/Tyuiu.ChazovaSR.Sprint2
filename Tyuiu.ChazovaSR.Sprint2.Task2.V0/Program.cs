using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint2.Task2.V0.Lib;

namespace Tyuiu.ChazovaSR.Sprint2.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.Title = "Спринт #2 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #2                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи      *");
            Console.WriteLine("* Задание #2                                              *");
            Console.WriteLine("* Вариант #0                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу, которая запрашивает целые значения с *");
            Console.WriteLine("*клавиатуры и вычисляет находится ли точка с координатами *");
            Console.WriteLine("*X,Y в заштрихованной области.                            *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");


            Console.WriteLine("Введите значение переменной Х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не  находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
    
}
