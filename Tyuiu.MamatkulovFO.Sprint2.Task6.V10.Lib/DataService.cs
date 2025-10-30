using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {


        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            // Если день > 1 — просто вычитаем 1
            if (n > 1)
                return $"{n - 1:D2}.{m:D2}.{g}";

            // Если день == 1 — переходим на последний день предыдущего месяца
            if (m > 1)
            {
                int prevMonth = m - 1;
                int daysInPrevMonth = GetDaysInMonth(prevMonth);
                return $"{daysInPrevMonth:D2}.{prevMonth:D2}.{g}";
            }

            // Если месяц == 1 и день == 1 — переходим на 31 декабря предыдущего года
            return $"31.12.{g - 1}";
        }

        /// <summary>
        /// Возвращает количество дней в месяце (год не високосный)
        /// </summary>
        /// <param name="month">Номер месяца (1-12)</param>
        /// <returns>Количество дней</returns>
        private int GetDaysInMonth(int month)
        {
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return days[month - 1]; // индекс с 0
        }
    }
}
    

    

