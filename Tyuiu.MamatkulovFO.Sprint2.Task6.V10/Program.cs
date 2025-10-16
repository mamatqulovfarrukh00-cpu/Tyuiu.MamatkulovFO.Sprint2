using Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task6.V10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите год, месяц и день:");
            int g = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            var ds = new DataService();
            Console.WriteLine("Предыдущий день: " + ds.FindDateOfPreviousDay(g, m, n));
        }
    }
}
