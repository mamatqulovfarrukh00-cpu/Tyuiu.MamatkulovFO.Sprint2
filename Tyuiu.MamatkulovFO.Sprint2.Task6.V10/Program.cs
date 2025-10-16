using Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task6.V10;

    

    class Program
    {
        static void Main()
        {
            Console.Write("g = ");
            int g = int.Parse(Console.ReadLine());

            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            var (y, mo, d) = DataService.GetPreviousDay(g, m, n);

            Console.WriteLine($"{y} {mo} {d}");
        }
    }


