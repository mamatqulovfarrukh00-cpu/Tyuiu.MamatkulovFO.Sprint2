using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task5.V14.Lib
{ 
    public class DataService:ISprint2Task5V14
    {
        public string GetDayOfWeek(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public string Run(int k, int d)
        {
            // 1 yanvar d-kun (1=Dushanba, 7=Yakshanba)
            // k - yilning nechanchi kuni

            // Kunlarni hisoblash: (d + k - 1) % 7
            int dayIndex = (d + k - 1) % 7;
            if (dayIndex == 0) dayIndex = 7; // 0 -> 7 (Yakshanba)

            // Rus tilida kun nomini qaytarish
            var culture = new CultureInfo("ru-RU");
            var dayName = ((DayOfWeek)(dayIndex - 1)).ToString("dddd", culture);

            return dayName;
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        string ISprint2Task5V14.FindDayName(int k, int d)
        {
            throw new NotImplementedException();
        }
    }
}

