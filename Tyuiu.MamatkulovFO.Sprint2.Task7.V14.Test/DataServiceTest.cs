namespace Tyuiu.MamatkulovFO.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void ValidTest()
        {
            var ds = new DataService();
            bool res = ds.CheckDotInShadedArea(0, 1);
            Assert.IsTrue(res);
        }
    }
}
