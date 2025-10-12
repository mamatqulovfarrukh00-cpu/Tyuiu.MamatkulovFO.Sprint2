using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task5.V14.Lib
{ 
    public class DataService:ISprint2Task5V14
    {
        public object Run()
        {
            int k = 20;
            int d = 7;
            int dayIndex = (d + k - 1) % 7;
            if (dayIndex == 0) dayIndex = 7;

            string[] days = {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"
        };

            return days[dayIndex - 1];
        }

        public object? Run(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        string ISprint2Task5V14.FindDayName(int k, int d)
        {
            throw new NotImplementedException();
        }
    }
}


