using Tyuiu.MamatkulovFO.Sprint2.Task5.V14.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task5.V14.Test
{
    
    public class DataServiceTest
    {
        // Простой ручной тест без фреймворка (работает в любом консольном приложении)
        public static void RunAllTests()
        {
            DataService service = new DataService();
            bool allPassed = true;

            // Тест 1: 1 января — понедельник, 1-й день → понедельник
            if (service.GetDayOfWeek(1, 1) != "понедельник")
            {
                Console.WriteLine("❌ Тест 1 провален");
                allPassed = false;
            }

            // Тест 2: 1 января — четверг (d=4), 365-й день → суббота
            if (service.GetDayOfWeek(365, 4) != "суббота")
            {
                Console.WriteLine("❌ Тест 2 провален");
                allPassed = false;
            }

            // Тест 3: 1 января — понедельник, 7-й день → воскресенье
            if (service.GetDayOfWeek(7, 1) != "воскресенье")
            {
                Console.WriteLine("❌ Тест 3 провален");
                allPassed = false;
            }

            if (allPassed)
                Console.WriteLine("✅ Все тесты пройдены успешно!");
            else
                Console.WriteLine("⚠️ Некоторые тесты не пройдены.");
        }
    }
}
