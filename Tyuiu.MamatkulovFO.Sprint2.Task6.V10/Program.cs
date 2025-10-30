using Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task6.V10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Определение даты предыдущего дня ===");
            Console.Write("Введите год (g): ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            var service = new DataService();
            string prevDate = service.FindDateOfPreviousDay(g, m, n);

            Console.WriteLine($"Дата предыдущего дня: {prevDate}");
            Console.ReadKey();
        }
    }
}
