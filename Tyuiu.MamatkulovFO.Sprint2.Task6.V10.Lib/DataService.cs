
namespace Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Lib;

public class DataService:ISprint2Task6V10
{
    public static (int Year, int Month, int Day) GetPreviousDay(int year, int month, int day)
    {
        if (year <= 0 || month < 1 || month > 12 || day < 1)
            throw new ArgumentException("Invalid date");

        int daysInMonth = month switch
        {
            1 => 31,
            2 => 28,
            3 => 31,
            4 => 30,
            5 => 31,
            6 => 30,
            7 => 31,
            8 => 31,
            9 => 30,
            10 => 31,
            11 => 30,
            12 => 31,
            _ => throw new ArgumentException("Invalid month")
        };

        if (day > daysInMonth)
            throw new ArgumentException("Invalid day");

        if (day > 1)
            return (year, month, day - 1);

        if (month > 1)
        {
            int prevMonth = month - 1;
            int prevDay = prevMonth switch
            {
                1 => 31,
                2 => 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => 31
            };
            return (year, prevMonth, prevDay);
        }

        return (year - 1, 12, 31);
    }

   
}

