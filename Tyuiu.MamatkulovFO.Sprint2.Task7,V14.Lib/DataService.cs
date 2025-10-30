using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверяем, находится ли точка внутри или на границе круга
            bool inCircle = (x * x + y * y) <= 1.0;

            // Проверяем, находится ли точка в I или III четверти (y >= x ИЛИ y <= -x)
            bool inShadedQuadrants = (y >= x) || (y <= -x);

            // Точка должна быть и в круге, и в заштрихованных четвертях
            return inCircle && inShadedQuadrants;
        }
    }
}
