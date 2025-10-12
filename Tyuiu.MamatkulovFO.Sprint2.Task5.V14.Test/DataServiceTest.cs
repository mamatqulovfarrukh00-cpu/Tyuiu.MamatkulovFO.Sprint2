using Tyuiu.MamatkulovFO.Sprint2.Task5.V14.Lib;
namespace Tyuiu.MamatkulovFO.Sprint2.Task5.V14.Test
{
    
    public class DataServiceTest
    {
        // Простой ручной тест без фреймворка (работает в любом консольном приложении)
        [Fact]
        public void TestFriday()
        {
           
            var service = new DataService();
            string result = service.Run(5, 1);
            Assert.AreEqual("Пятница", result);
        }

        [Fact]
        public void TestMonday()
        {
            var service = new DataService();
            string result = service.Run(1, 1);
            Assert.AreEqual("Понедельник", result);
        }

        [Fact]
        public void TestSunday()
        {
            
            var service = new DataService();
            string result = service.Run(1, 7);
            Assert.AreEqual("Воскресенье", result);
        }
    }
}

