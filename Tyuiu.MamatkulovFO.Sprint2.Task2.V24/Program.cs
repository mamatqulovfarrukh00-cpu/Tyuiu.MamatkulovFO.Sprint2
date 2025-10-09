using Tyuiu.MamatkulovFO.Sprint2.Task2.V24.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task2.V24
{
    internal class Program
    {
        static void Main()
        {
            var dataService = new DataService();

            Console.WriteLine("========================================");
            Console.WriteLine("   Проверка принадлежности точки       ");
            Console.WriteLine("        заштрихованной области         ");
            Console.WriteLine("========================================");

            Console.Write("Введите координату X: ");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("Ошибка: введено некорректное значение для X.");
                return;
            }

            Console.Write("Введите координату Y: ");
            if (!double.TryParse(Console.ReadLine(), out double y))
            {
                Console.WriteLine("Ошибка: введено некорректное значение для Y.");
                return;
            }

            // Вызываем метод сервиса для проверки
            bool result = dataService.IsPointInShadedArea(x, y);

            Console.WriteLine();
            Console.WriteLine($"Точка ({x}, {y}) {(result ? "находится" : "НЕ находится")} в заштрихованной области.");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

