using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KvashninKA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            int d = (int)((x - Math.Truncate(x)) * 10);
            return d;
        }
    }

}