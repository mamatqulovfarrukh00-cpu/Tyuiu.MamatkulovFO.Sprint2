using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task0.V16.Lib;

public class DataService : ISprint2Task0V16
{
    public bool[] GetCompareOperations(int x, int y)
    {
        bool[] res = new bool[6];
        res[0] = x > y;          // True
        res[1] = x == y;         // False
        res[2] = x >= y + 1;     // True
        res[3] = x < y;          // False
        res[4] = (x - y) > 0;    // True
        res[5] = (x % y) == 0;   // False
        return res;
    }


}
