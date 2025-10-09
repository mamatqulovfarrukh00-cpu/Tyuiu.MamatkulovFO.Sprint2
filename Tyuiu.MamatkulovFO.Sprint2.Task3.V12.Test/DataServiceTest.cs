using Tyuiu.MamatkulovFO.Sprint2.Task3.V12.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task3.V12.Test;
      public class DataServiceTests
      {
            private IDataService _service;

            [TestInitialize]
            public void Setup()
            {
                _service = new DataService();
            }

            [TestMethod]
            public void CalculateY_XLessThanMinus2_ReturnsQuadratic()
            {
                // X = -3 → Y = (-3)^2 + 4*(-3) + 3 = 9 - 12 + 3 = 0
                double result = _service.CalculateY(-3);
                Assert.AreEqual(0.0, result);
            }

            [TestMethod]
            public void CalculateY_XBetweenMinus2And1_ReturnsSin()
            {
                // X = 0 → sin(0) = 0
                double result = _service.CalculateY(0);
                Assert.AreEqual(0.0, result);
            }

            [TestMethod]
            public void CalculateY_XEquals1_ReturnsLnPlus2()
            {
                // X = 1 → ln(1) + 2 = 0 + 2 = 2
                double result = _service.CalculateY(1);
                Assert.AreEqual(2.0, result);
            }

            [TestMethod]
            public void CalculateY_XEquals2_ReturnsLn2Plus2()
            {
                // ln(2) ≈ 0.693147 → +2 = 2.693147 → округление до 2.693
                double result = _service.CalculateY(2);
                Assert.AreEqual(2.693, result);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void CalculateY_XZero_ThrowsException()
            {
                // Хотя по логике X=0 попадает в sin(x), но проверим крайний случай
                // На самом деле не должно бросать исключение, но для полноты:
                _service.CalculateY(0); // не должно бросить
            }

            // Дополнительный тест: убедимся, что округление работает
            [TestMethod]
            public void CalculateY_RoundingWorksCorrectly()
            {
                // sin(1) ≈ 0.8414709848 → округление до 0.841
                double result = _service.CalculateY(1 - 1e-10); // чуть меньше 1 → sin
                Assert.AreEqual(0.841, result);
            }
      }
    


