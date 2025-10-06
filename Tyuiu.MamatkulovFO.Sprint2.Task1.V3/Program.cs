using Tyuiu.MamatkulovFO.Sprint2.Task1.V3.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task1.V3
{
    class Program
    {
        static void Main()
        {
            int a = 185, b = 316, c = 134, d = 134;
            bool[] result = DataService.GetLogicSequence(a, b, c, d);
            Console.WriteLine($"({string.Join(", ", result.Select(r => r.ToString()))})");
            Console.ReadLine();
        }
    }
}
