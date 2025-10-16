using Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTest() => Assert.AreEqual("2025.10.26",
            new DataService().FindDateOfPreviousDay(2025, 10, 27));
    }
}
