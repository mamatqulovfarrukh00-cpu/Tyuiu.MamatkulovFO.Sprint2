using Tyuiu.MamatkulovFO.Sprint2.Task2.V24.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        private DataService _service = new();

        [TestMethod]
        public void ТочкаВНачалеКоординат_ВКруге_ДолжнаВернутьTrue()
        {
            // Точка (0, 0) находится внутри круга радиуса 2
            Assert.IsTrue(_service.IsPointInShadedArea(0, 0));
        }

        [TestMethod]
        public void ТочкаВПервойЧетвертиВнеКруга_ДолжнаВернутьTrue()
        {
            // Точка (3, 4) — вне круга, но в первой четверти → попадает в область
            Assert.IsTrue(_service.IsPointInShadedArea(3, 4));
        }

        [TestMethod]
        public void ТочкаВТретьейЧетверти_НеПопадает_ДолжнаВернутьFalse()
        {
            // Точка (-2, -3) — не в круге и не в первой четверти
            Assert.IsFalse(_service.IsPointInShadedArea(-2, -3));
        }

        [TestMethod]
        public void ТочкаНаГраницеКруга_ДолжнаВернутьTrue()
        {
            // Точка (2, 0) лежит на окружности радиуса 2 → включена в область
            Assert.IsTrue(_service.IsPointInShadedArea(2, 0));
        }
    }
}

