using Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Test;



    public class DataServiceTest
    {
        [Fact]
        public void Test_October16_ReturnsOctober15()
        {
            var result = DataService.GetPreviousDay(2025, 10, 16);
            Assert.AreEqual((2025, 10, 15), result);
        }

        [Fact]
        public void Test_March1_ReturnsFebruary28()
        {
            var result = DataService.GetPreviousDay(2025, 3, 1);
            Assert.AreEqual((2025, 2, 28), result);
        }

        [Fact]
        public void Test_January1_ReturnsDecember31PreviousYear()
        {
            var result = DataService.GetPreviousDay(2025, 1, 1);
            Assert.AreEqual((2024, 12, 31), result);
        }

        [Fact]
        public void Test_April1_ReturnsMarch31()
        {
            var result = DataService.GetPreviousDay(2025, 4, 1);
            Assert.AreEqual((2025, 3, 31), result);
        }
    }

