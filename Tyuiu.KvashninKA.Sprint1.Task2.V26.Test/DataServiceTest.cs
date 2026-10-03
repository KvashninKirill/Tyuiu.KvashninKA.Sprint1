using Tyuiu.KvashninKA.Sprint1.Task2.V26.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task2.V26.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int hours = 2;
            int minutes = 30;
            int res = ds.CalculateMinutesSinceStart(hours, minutes);

            Assert.AreEqual(150, res);
        }
    }
}