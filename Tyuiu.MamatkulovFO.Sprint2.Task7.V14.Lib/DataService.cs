using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Точка должна быть внутри или на границе круга
            bool inCircle = (x * x + y * y) <= 1.0;

            // Заштрихованная область — это II и IV четверти: y < x И y > -x
            // То есть: между прямыми y = x и y = -x, но не включая их
            bool inShadedArea = (y < x) && (y > -x);

            return inCircle && inShadedArea;
        }
    }
}
