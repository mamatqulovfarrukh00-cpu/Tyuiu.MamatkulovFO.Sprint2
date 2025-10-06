using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task1.V3.Lib
{
    public class DataService:ISprint2Task1V3
    {
        public static bool[] GetLogicSequence(int a, int b, int c, int d)
        {
            return new bool[]
            {
            c == d,
            (a == 185) ^ true,
            (b == 316) & false,
            c != 134,
            !(d == 134),
            a > 200
            };
        }

        bool[] ISprint2Task1V3.GetLogicOperations(int a, int b, int c, int d)
        {
            throw new NotImplementedException();
        }
    }
}
