using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        
        
            public string FindDateOfPreviousDay(int g, int m, int n)
            {
                int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if (n > 1) return $"{g}.{m}.{n - 1}";

                if (m > 1) return $"{g}.{m - 1}.{days[m - 2]}";

                return $"{g - 1}.12.31";
            }
        
    }
}
