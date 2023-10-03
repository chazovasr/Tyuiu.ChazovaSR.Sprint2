using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint2.Task1.V1.Lib;
namespace Tyuiu.ChazovaSR.Sprint2.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #2                                               *");
            Console.WriteLine("* Тема: Логические операции                               *");
            Console.WriteLine("* Задание #1                                              *");
            Console.WriteLine("* Вариант #1                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу из операций сравнений ==,!=,<,>,<=,>=, ");
            Console.WriteLine("*последовательность можно чередовать, но использовать один*");
            Console.WriteLine("*раз в выражении и логических операций( |,&, ||, && , !,^ *");
            Console.WriteLine("*последовательность операций не должна нарушаться)        *");
            Console.WriteLine("*и арифметических выражений, которая вернет массив        *");
            Console.WriteLine("*(True,False,True,False,True,False)                       *");
            Console.WriteLine("* при а=119,b=196,c=134, d=327                            *");
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
