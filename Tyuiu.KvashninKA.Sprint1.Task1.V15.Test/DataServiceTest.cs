using Tyuiu.KvashninKA.Sprint1.Task1.V15.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task1.V15.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(2, res);

        }
    }
}