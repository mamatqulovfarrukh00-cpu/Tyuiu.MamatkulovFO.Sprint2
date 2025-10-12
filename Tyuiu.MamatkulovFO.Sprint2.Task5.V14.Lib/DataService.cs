using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MamatkulovFO.Sprint2.Task5.V14.Lib
{ 
    public class DataService:ISprint2Task5V14
    {
        public string Run(int k, int d)
        {
            int dayIndex = (d + k - 1) % 7;
            if (dayIndex == 0) dayIndex = 7;

            switch (dayIndex)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: return "";
            }
        }
        string ISprint2Task5V14.FindDayName(int k, int d)
        {
            throw new NotImplementedException();
        }
    }
}


