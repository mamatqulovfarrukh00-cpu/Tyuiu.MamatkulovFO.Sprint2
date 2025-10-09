using Tyuiu.MamatkulovFO.Sprint2.Task4.V3.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [Test]
        public void Test_CalculateZ_When_X_Less_Y_Minus_One()
        {
            var service = new DataService();
            double result = service.CalculateZ(1.0, 3.0); // x=1 < y-1=2 → используем первую формулу
            Assert.AreEqual(3.5, Math.Round(result, 3));
        }

        [Test]
        public void Test_CalculateZ_When_X_Not_Less_Y_Minus_One()
        {
            var service = new DataService();
            double result = service.CalculateZ(4.0, 3.0); // x=4 >= y-1=2 → вторая формула
            Assert.AreEqual(6.0, Math.Round(result, 3));
        }
    }
}

