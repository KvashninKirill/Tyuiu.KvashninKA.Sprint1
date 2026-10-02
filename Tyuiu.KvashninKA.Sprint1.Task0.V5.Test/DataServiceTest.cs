using Tyuiu.KvashninKA.Sprint1.Task0.V5.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task0.V5.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(12, ds.Calculate());
        }
    }
}