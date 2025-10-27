using System;
using Tyuiu.MamatkulovFO.Sprint2.Task7.V14.Lib;

namespace Tyuiu.MamatkulovFO.Sprint2.Task7.V14
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Sprint 2 | Task 7 | Variant 14";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа проверки принадлежности точки заштрихованной области          *");
            Console.WriteLine("***************************************************************************");

            var ds = new DataService();

            Console.Write("Введите координату X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = double.Parse(Console.ReadLine());

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Результат: {(result ? "Точка в заштрихованной области" : "Точка вне области")} *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}

