using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task4.V3.Lib
{
    public class DataService:ISprint2Task4V3
    {
        public double Calculate(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double CalculateZ(double x, double y)
            {
                // Если x < y - 1, то z = y + (y-1)/(x+2), иначе z = x + 2y * (1/(y+3))
                return x < y - 1
                    ? y + (y - 1) / (x + 2)
                    : x + 2 * y * (1.0 / (y + 3));
            }
        
    }
}
