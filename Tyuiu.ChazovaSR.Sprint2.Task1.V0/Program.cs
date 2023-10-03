using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint2.Task1.V0.Lib;

namespace Tyuiu.ChazovaSR.Sprint2.Task1.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 15;
            int b = 16;
            int c = 14;
            int d = 17;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);

            Console.Title = "Спринт #2 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #2                                               *");
            Console.WriteLine("* Тема: Логические операции                               *");
            Console.WriteLine("* Задание #1                                              *");
            Console.WriteLine("* Вариант #0                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу из операций сравнений ==,!=,<,>,<=,>=, ");
            Console.WriteLine("*последовательность можно чередовать, но использовать один*");
            Console.WriteLine("*раз в выражении и логических операций( |,&, ||, && , !,^ *");
            Console.WriteLine("*последовательность операций не должна нарушаться)        *");
            Console.WriteLine("*и арифметических выражений, которая вернет массив        *");
            Console.WriteLine("*(True,True,True,True,True,True), при а=15,b=16,c=14, d=17*");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");


            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
