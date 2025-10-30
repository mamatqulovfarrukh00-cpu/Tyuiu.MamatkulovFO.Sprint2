using Tyuiu.MamatkulovFO.Sprint2.Task7.V14.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task7.V14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Проверка точки в заштрихованной области ===");
            Console.Write("Введите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            var service = new DataService();
            bool isInArea = service.CheckDotInShadedArea(x, y);

            if (isInArea)
                Console.WriteLine("✅ Точка находится в заштрихованной области.");
            else
                Console.WriteLine("❌ Точка НЕ находится в заштрихованной области.");

            Console.ReadKey();
        }
    }
}
