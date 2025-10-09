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
            if (x < y - 1)
            {
                return y + (y - 1) / (x + 2);
            }
            else
            {
                return x + 2 * y / (y + 3);
            }
        }
    }
}
