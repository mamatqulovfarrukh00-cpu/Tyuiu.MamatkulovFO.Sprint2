using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task3.V12.Lib
{
    using System;

    namespace ClassLibrary
    {
        /// <summary>
        /// Реализация интерфейса IDataService.
        /// Вычисляет значение функции Y по заданной кусочной формуле:
        /// 
        /// y = { 
        ///      x + ((x+1)/(x-1))^x,         если x > 1
        ///      1 + cos(√(x+1)),             если x = 0
        ///      (7 + 5/x²)^x,                 если -16 < x < 2
        ///      x + 10x - (1/x),              если x < -16
        ///     }
        /// 
        /// Результат округляется до 3 знаков после запятой.
        /// </summary>
        public class DataService : IDataService
        {
            public double CalculateY(double x)
            {
                double y;

                if (x > 1)
                {
                    // Проверка: x != 1 (хотя условие x>1 гарантирует это)
                    double baseVal = (x + 1) / (x - 1);
                    y = x + Math.Pow(baseVal, x);
                }
                else if (x == 0)
                {
                    y = 1 + Math.Cos(Math.Sqrt(x + 1)); // cos(√1) = cos(1)
                }
                else if (x < -16)
                {
                    y = 11 * x - (1.0 / x); // x + 10x = 11x
                }
                else if (x > -16 && x < 2)
                {
                    // Условие: -16 < x < 2, но x != 0 (уже обработано выше)
                    double baseVal = 7 + 5.0 / (x * x);
                    y = Math.Pow(baseVal, x);
                }
                else
                {
                    // Остальные случаи — например, x = 1 или x = -16
                    throw new ArgumentException($"Значение x={x} не определено в данной функции.");
                }

                return Math.Round(y, 3);
            }
        }
    }
}
