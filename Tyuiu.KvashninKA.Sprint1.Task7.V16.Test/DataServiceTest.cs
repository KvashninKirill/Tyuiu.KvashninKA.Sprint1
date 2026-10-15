using Tyuiu.KvashninKA.Sprint1.Task7.V16.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task7.V16.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        { 
            DataService ds = new DataService();
            double x = 1;
            double wait = Math.Round(Math.Sin(Math.Sqrt(1)) + Math.Cos(1) / 3 - Math.Sin(Math.Sqrt(0)), 3);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
