using Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Test
{
    
    
        [TestClass]
        public class DataServiceTest
        {
            private DataService _service;

            [TestInitialize]
            public void Setup()
            {
                _service = new DataService();
            }

            // ✅ Простой случай: день > 1
            [TestMethod]
            public void День_больше_1_возвращается_предыдущий_день()
            {
                string result = _service.FindDateOfPreviousDay(2025, 10, 5);
                Assert.AreEqual("04.10.2025", result);
            }

            // ✅ Переход на предыдущий месяц (например, 1 марта → 28 февраля)
            [TestMethod]
            public void Первое_число_марта_переходит_на_февраль()
            {
                string result = _service.FindDateOfPreviousDay(2025, 3, 1);
                Assert.AreEqual("28.02.2025", result);
            }

            // ✅ Переход на предыдущий год (1 января → 31 декабря предыдущего года)
            [TestMethod]
            public void Первое_января_переходит_на_предыдущий_год()
            {
                string result = _service.FindDateOfPreviousDay(2025, 1, 1);
                Assert.AreEqual("31.12.2024", result);
            }

            // ✅ Последний день месяца (31 мая → 30 мая)
            [TestMethod]
            public void Последний_день_месяца_возвращается_предыдущий_день()
            {
                string result = _service.FindDateOfPreviousDay(2025, 5, 31);
                Assert.AreEqual("30.05.2025", result);
            }

            // ✅ 1 апреля → 31 марта
            [TestMethod]
            public void Первое_апреля_переходит_на_март()
            {
                string result = _service.FindDateOfPreviousDay(2025, 4, 1);
                Assert.AreEqual("31.03.2025", result);
            }

            // ✅ 1 июня → 31 мая
            [TestMethod]
            public void Первое_июня_переходит_на_май()
            {
                string result = _service.FindDateOfPreviousDay(2025, 6, 1);
                Assert.AreEqual("31.05.2025", result);
            }

            // ✅ 1 ноября → 31 октября
            [TestMethod]
            public void Первое_ноября_переходит_на_октябрь()
            {
                string result = _service.FindDateOfPreviousDay(2025, 11, 1);
                Assert.AreEqual("31.10.2025", result);
            }

            // ✅ 1 февраля → 31 января
            [TestMethod]
            public void Первое_февраля_переходит_на_январь()
            {
                string result = _service.FindDateOfPreviousDay(2025, 2, 1);
                Assert.AreEqual("31.01.2025", result);
            }

            // ✅ 1 декабря → 30 ноября
            [TestMethod]
            public void Первое_декабря_переходит_на_ноябрь()
            {
                string result = _service.FindDateOfPreviousDay(2025, 12, 1);
                Assert.AreEqual("30.11.2025", result);
            }
        }
    
}
