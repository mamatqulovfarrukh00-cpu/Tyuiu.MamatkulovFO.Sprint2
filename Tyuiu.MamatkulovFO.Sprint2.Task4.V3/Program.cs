using Tyuiu.MamatkulovFO.Sprint2.Task4.V3.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task4.V3
{
    class Program
    {
        static void Main()
        {
            var service = new DataService();

            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите y: ");
            double y = double.Parse(Console.ReadLine());

            double result = service.CalculateZ(x, y);

            // Округление до 3 знаков после запятой
            Console.WriteLine($"Результат: {Math.Round(result, 3)}");
        }
    }
}
