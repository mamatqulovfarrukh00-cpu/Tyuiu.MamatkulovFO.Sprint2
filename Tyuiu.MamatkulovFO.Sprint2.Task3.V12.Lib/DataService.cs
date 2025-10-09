using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task3.V12.Lib
{
    using System;

    namespace ClassLibrary
    {
        /// <summary>
        /// Реализация интерфейса IDataService.
        /// Вычисляет значение функции Y по следующему правилу:
        /// 
        /// если X < -2 → Y = X² + 4X + 3
        /// если -2 ≤ X < 1 → Y = sin(X)
        /// если X ≥ 1 → Y = ln(X) + 2
        /// 
        /// Результат округляется до 3 знаков после запятой.
        /// </summary>
        public class DataService : ISprint2Task3V12
        {
            public double CalculateY(double x)
            {
                double y;

                if (x < -2)
                {
                    y = x * x + 4 * x + 3;
                }
                else
                {
                    if (x < 1)
                    {
                        y = Math.Sin(x);
                    }
                    else
                    {
                        // x >= 1
                        if (x <= 0)
                        {
                            // Теоретически недостижимо, т.к. x >= 1, но для безопасности
                            throw new ArgumentException("Невозможно вычислить ln(X) для X <= 0");
                        }
                        y = Math.Log(x) + 2;
                    }
                }

                // Округление до 3 знаков после запятой
                return Math.Round(y, 3);
            }

            double ISprint2Task3V12.Calculate(double x)
            {
                throw new NotImplementedException();
            }
        }
    }
}
