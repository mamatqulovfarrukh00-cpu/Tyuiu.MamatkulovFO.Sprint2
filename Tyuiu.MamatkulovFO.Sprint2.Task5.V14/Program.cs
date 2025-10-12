using Tyuiu.MamatkulovFO.Sprint2.Task5.V14.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task5.V14
{
    class Program
    {
        static void Main()
        {
            var service = new DataService();
            Console.WriteLine(service.Run(20, 7));
        }
    }

        
    
}
