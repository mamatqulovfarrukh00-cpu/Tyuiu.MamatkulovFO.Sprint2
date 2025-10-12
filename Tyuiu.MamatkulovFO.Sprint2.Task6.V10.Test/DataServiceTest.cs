using Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [Fact]
        public void TestPreviousDay()
        {
            var service = new DataService();
            var result = service.Run(2025, 3, 1);
            Assert.AreEqual("28.2.2025", result);
        }
    }
}
