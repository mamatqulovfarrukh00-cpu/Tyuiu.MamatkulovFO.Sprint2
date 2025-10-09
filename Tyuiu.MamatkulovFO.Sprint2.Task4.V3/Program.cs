using Tyuiu.MamatkulovFO.Sprint2.Task4.V3.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task4.V3
{
    class Program
    {
        static void Main()
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            var service = new DataService();
            double z = service.CalculateZ(x, y);

            Console.WriteLine($"z = {z:F3}");

            
        }
    }
}
