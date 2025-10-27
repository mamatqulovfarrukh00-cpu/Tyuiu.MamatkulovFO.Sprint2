using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task7.V14.Lib

{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // y >= x² va y <= 2 - x²
            double lowerBound = x * x;           // y = x²
            double upperBound = 2 - x * x;       // y = 2 - x²

            return y >= lowerBound && y <= upperBound;
        }
    }
}
