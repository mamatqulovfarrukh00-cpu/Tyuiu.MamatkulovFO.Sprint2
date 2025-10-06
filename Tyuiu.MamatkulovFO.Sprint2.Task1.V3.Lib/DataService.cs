using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task1.V3.Lib
{
    public class DataService:ISprint2Task1V3
    {
        public static bool[] GetLogicSequence(int a, int b, int c, int d)
        {
            return new bool[]
            {
            (c == d) && ((a + b) > 400),
            ((a - c) == 51) && (b < 300),
            (a > b) | (c != d),
            ((b - a) > 130) & (d == 135),
            !(a == 185) || (c < d),
            ((a + c) >= 320) | (b <= 300)
            };
        }

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            throw new NotImplementedException();
        }
    }
}
