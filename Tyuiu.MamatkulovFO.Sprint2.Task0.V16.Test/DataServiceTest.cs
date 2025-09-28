using Tyuiu.MamatkulovFO.Sprint2.Task0.V16.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task0.V16.Test;
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1025;
            int y = 275;

            bool[] res = ds.GetCompareOperations(x, y);
            bool[] wait = { true, false, true, false, true, false };


            CollectionAssert.AreEqual(wait, res);
        }


    }

