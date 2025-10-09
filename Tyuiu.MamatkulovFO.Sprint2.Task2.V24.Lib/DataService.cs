using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task2.V24.Lib
{
  
    public class DataService:ISprint2Task2V24
    {
        /// <summary>
        /// Проверяет, находится ли точка (x, y) в заштрихованной области.
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <returns>Возвращает true, если точка в заштрихованной области; иначе — false.</returns>
        public bool IsPointInShadedArea(double x, double y)
        {
            // Проверяем, находится ли точка внутри круга радиуса 2 (включая границу)
            bool inCircle = (x * x + y * y <= 4);

            // Проверяем, находится ли точка в первой координатной четверти (x > 0 и y > 0)
            bool inFirstQuadrant = (x > 0 && y > 0);

            // Точка считается попавшей в область, если выполняется хотя бы одно условие
            return inCircle || inFirstQuadrant;
        }

        bool ISprint2Task2V24.CheckDotInShadedArea(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
