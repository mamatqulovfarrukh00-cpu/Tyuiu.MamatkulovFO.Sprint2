using Tyuiu.MamatkulovFO.Sprint2.Task5.V14.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task5.V14.Test
{
    
    public class DataServiceTest
    {
        [Fact]
        public void TestRun()
        {
            var service = new DataService();
            var result = service.Run(20, 7);
            Assert.AreEqual("Пятница", result);
        }
    }
}

