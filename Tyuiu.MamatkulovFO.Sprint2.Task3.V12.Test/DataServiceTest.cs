using Tyuiu.MamatkulovFO.Sprint2.Task3.V12.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task3.V12.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class DataServiceTests
{
    private IDataService _service;

    [TestInitialize]
    public void Setup()
    {
        _service = new DataService();
    }

    [TestMethod]
    public void CalculateY_XEquals5_Returns12_594()
    {
        // x = 5 → y = 5 + (6/4)^5 = 5 + 1.5^5 = 5 + 7.59375 = 12.59375 → округление до 12.594
        double result = _service.CalculateY(5);
        Assert.AreEqual(12.594, result);
    }

    [TestMethod]
    public void CalculateY_XEquals0_ReturnsCos1Plus1()
    {
        // x = 0 → y = 1 + cos(√1) = 1 + cos(1) ≈ 1 + 0.5403 = 1.540
        double result = _service.CalculateY(0);
        Assert.AreEqual(1.540, result);
    }

    [TestMethod]
    public void CalculateY_XEqualsMinus17_ReturnsNegativeValue()
    {
        // x = -17 → y = 11*(-17) - (1/-17) = -187 + 0.0588235 ≈ -186.941
        double result = _service.CalculateY(-17);
        Assert.AreEqual(-186.941, result);
    }

    [TestMethod]
    public void CalculateY_XEqualsMinus10_ReturnsPowerOfBase()
    {
        // x = -10 → y = (7 + 5/100)^(-10) = (7.05)^(-10)
        double baseVal = 7 + 5.0 / (10 * 10);
        double expected = Math.Pow(baseVal, -10);
        double result = _service.CalculateY(-10);
        Assert.AreEqual(Math.Round(expected, 3), result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateY_XEquals1_ThrowsException()
    {
        _service.CalculateY(1); // Деление на ноль в (x+1)/(x-1)
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateY_XEqualsMinus16_ThrowsException()
    {
        _service.CalculateY(-16); // Граница, не входит ни в один интервал
    }
}


