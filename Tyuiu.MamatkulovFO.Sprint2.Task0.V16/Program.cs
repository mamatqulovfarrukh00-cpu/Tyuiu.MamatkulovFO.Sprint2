using Tyuiu.MamatkulovFO.Sprint2.Task0.V16.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task0.V16;
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 1025;
            int y = 275;
            bool[] res = ds.GetCompareOperations(x, y);

            Console.WriteLine("*******************************");
            Console.WriteLine("*    исходный данные           ");
            Console.WriteLine("*******************************");
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("********************************");
            Console.WriteLine("РЕЗУЛЬТАТ;");

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }


            Console.ReadKey();

        }


    }

