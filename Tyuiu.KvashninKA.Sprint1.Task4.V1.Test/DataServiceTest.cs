using Tyuiu.KvashninKA.Sprint1.Task4.V1.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task4.V1.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double wait = 0.04;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}