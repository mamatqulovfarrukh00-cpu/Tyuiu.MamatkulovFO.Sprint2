using Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task6.V10
{
    class Program
    {
        static void Main()
        {
            var service = new DataService();
            System.Console.WriteLine(service.Run(2025, 3, 1)); // "28.2.2025"
        }
    }
}
