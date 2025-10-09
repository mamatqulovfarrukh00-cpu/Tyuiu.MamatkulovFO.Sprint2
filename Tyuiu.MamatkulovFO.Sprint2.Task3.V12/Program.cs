using Tyuiu.MamatkulovFO.Sprint2.Task3.V12.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task3.V12
{
    
   

    namespace ConsoleApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите значение X:");
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    IDataService service = new DataService();
                    try
                    {
                        double result = service.CalculateY(x);
                        Console.WriteLine($"Y = {result:F3}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                }

                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
            }
        }
    }
}
