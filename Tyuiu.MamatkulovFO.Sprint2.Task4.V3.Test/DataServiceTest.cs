using Tyuiu.MamatkulovFO.Sprint2.Task4.V3.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        public static void RunTests()
        {
            var service = new DataService();

            // Тест 1: x < y - 1
            double z1 = service.CalculateZ(1.0, 5.0);
            Console.WriteLine($"Тест 1 (x=1, y=5): {z1:F3}"); // Ожидается ≈ 6.333

            // Тест 2: x >= y - 1
            double z2 = service.CalculateZ(4.0, 3.0);
            Console.WriteLine($"Тест 2 (x=4, y=3): {z2:F3}"); // Ожидается = 5.000
        }
    }
}
