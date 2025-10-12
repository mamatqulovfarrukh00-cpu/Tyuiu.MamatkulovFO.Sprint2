using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task5.V14.Lib
{ 
    public class DataService
    {
        // Массив дней недели: 0 = понедельник, 6 = воскресенье
        private readonly string[] _days = {
        "понедельник", "вторник", "среда",
        "четверг", "пятница", "суббота", "воскресенье"
    };

        // Запуск интерактивного режима
        public void Run()
        {
            Console.WriteLine("=== Определение дня недели ===");

            int k = ReadInput("Введите номер дня в году (1–365): ", 1, 365);
            if (k == -1) return;

            int d = ReadInput("Введите день недели 1 января (1=пн, 7=вс): ", 1, 7);
            if (d == -1) return;

            string result = GetDayOfWeek(k, d);
            Console.WriteLine($"{k}-й день года — это {result}.");
        }

        // Безопасное чтение целого числа в заданном диапазоне
        private int ReadInput(string prompt, int min, int max)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                return value;

            Console.WriteLine($"Ошибка: введите число от {min} до {max}.");
            return -1;
        }

        // Вычисление дня недели (имитация switch через массив)
        public string GetDayOfWeek(int k, int d)
        {
            int index = (d - 1 + k - 1) % 7; // смещение от понедельника
            return _days[index];
        }
    }
}
