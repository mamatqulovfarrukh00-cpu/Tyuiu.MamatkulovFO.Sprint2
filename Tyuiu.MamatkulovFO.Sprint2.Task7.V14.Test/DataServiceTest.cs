using Tyuiu.MamatkulovFO.Sprint2.Task7.V14.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task7.V14.Test
{
    
        [TestClass]
        public class DataServiceTest
        {
            [TestMethod]
            public void CheckDotInShadedArea_PointInSecondQuadrantInsideCircle_ReturnsTrue()
            {
                var service = new DataService();
                // Точка (-0.5, 0.3) — во II четверти, внутри круга, и между y=x и y=-x
                bool result = service.CheckDotInShadedArea(-0.5, 0.3);
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void CheckDotInShadedArea_PointInFourthQuadrantInsideCircle_ReturnsTrue()
            {
                var service = new DataService();
                // Точка (0.5, -0.3) — в IV четверти, внутри круга, и между y=x и y=-x
                bool result = service.CheckDotInShadedArea(0.5, -0.3);
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void CheckDotInShadedArea_PointInFirstQuadrant_ReturnsFalse()
            {
                var service = new DataService();
                // Точка (0.5, 0.6) — в I четверти → не заштриховано
                bool result = service.CheckDotInShadedArea(0.5, 0.6);
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void CheckDotInShadedArea_PointOutsideCircle_ReturnsFalse()
            {
                var service = new DataService();
                // Точка (1.5, 0) — вне круга
                bool result = service.CheckDotInShadedArea(1.5, 0);
                Assert.IsFalse(result);
            }
        }
    
}
