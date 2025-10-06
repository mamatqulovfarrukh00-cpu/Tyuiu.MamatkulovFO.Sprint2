using Tyuiu.MamatkulovFO.Sprint2.Task1.V3.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void GetLogicSequence_ReturnsCorrectSequence_ForGivenInput()
        {
            int a = 185, b = 316, c = 134, d = 134;
            bool[] expected = new bool[] { true, false, false, false, false, false };
            bool[] actual = DataService.GetLogicSequence(a, b, c, d);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
