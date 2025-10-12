using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task5.V14.Lib
{ 
    public class DataService:ISprint2Task5V14
    {
        [Obsolete]
        public string Run(int k, int d)
        {
            

            int dayIndex = (d + k - 1) % 7;
            if (dayIndex == 0) dayIndex = 7; 

            
            DayOfWeek dayOfWeek = (DayOfWeek)(dayIndex - 1);

            
            var culture = new CultureInfo("ru-RU");
            string dayName = dayOfWeek.ToString("dddd", culture);

            return dayName;
        }

        string ISprint2Task5V14.FindDayName(int k, int d)
        {
            throw new NotImplementedException();
        }
    }
}

