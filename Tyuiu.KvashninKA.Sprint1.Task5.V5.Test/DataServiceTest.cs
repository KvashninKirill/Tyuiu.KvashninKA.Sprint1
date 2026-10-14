using Tyuiu.KvashninKA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task5.V5.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32.597;
            int wait = 5;
            int res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
            
        }
    }
}