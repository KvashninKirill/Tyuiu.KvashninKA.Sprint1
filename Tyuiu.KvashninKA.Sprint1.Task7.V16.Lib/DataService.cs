using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KvashninKA.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            double ur1 = Math.Sin(Math.Sqrt(Math.Pow(x, 2)));
            double ur2 = Math.Cos(Math.Pow(x, 2)) / (3 * Math.Pow(x, 3));
            double ur3 = Math.Sin(Math.Sqrt(Math.Pow(x, 2) - 1));

            double res = ur1 + ur2 - ur3;

            return Math.Round(res, 3);
        }
    }

}