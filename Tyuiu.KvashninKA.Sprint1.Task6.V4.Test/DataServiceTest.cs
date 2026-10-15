using Tyuiu.KvashninKA.Sprint1.Task6.V4.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task6.V4.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Народный уполномоченный мэр";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(strTest);
            string wait = "уполномоченный";
            Assert.AreEqual(wait, res);
        }
    }
}
