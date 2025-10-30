using Tyuiu.MamatkulovFO.Sprint2.Task7.V14.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task7.V14.Test
{
    [TestClass]
        public class DataServiceTest
        {
            [TestMethod]
            public void CheckDotInShadedArea_PointInsideCircleAndInIQuadrant_ReturnsTrue()
            {
                var service = new DataService();
                // Точка (0.5, 0.6) — в круге и выше y=x → I четверть
                bool result = service.CheckDotInShadedArea(0.5, 0.6);
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void CheckDotInShadedArea_PointInsideCircleAndInIIIQuadrant_ReturnsTrue()
            {
                var service = new DataService();
                // Точка (-0.5, -0.6) — в круге и ниже y=-x → III четверть
                bool result = service.CheckDotInShadedArea(-0.5, -0.6);
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void CheckDotInShadedArea_PointOutsideCircle_ReturnsFalse()
            {
                var service = new DataService();
                // Точка (1.5, 0) — вне круга
                bool result = service.CheckDotInShadedArea(1.5, 0);
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void CheckDotInShadedArea_PointInCircleButInIIQuadrant_ReturnsFalse()
            {
                var service = new DataService();
                // Точка (-0.5, 0.6) — в круге, но во II четверти (y > x и y > -x) → не заштриховано
                bool result = service.CheckDotInShadedArea(-0.5, 0.6);
                Assert.IsFalse(result);
            }
        }
    
}
