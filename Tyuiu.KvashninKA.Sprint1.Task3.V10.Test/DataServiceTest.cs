using Tyuiu.KvashninKA.Sprint1.Task3.V10.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task3.V10.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double value = 23.6;
            string res = ds.NumberToMoney(value);
            Assert.AreEqual("23 руб. 60 коп.", res);
        }
    }
}