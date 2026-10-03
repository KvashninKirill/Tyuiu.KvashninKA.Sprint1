using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KvashninKA.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
           double rounded = Math.Round(number, 2, MidpointRounding.AwayFromZero);
            int rubles = (int)Math.Truncate(rounded);
            int kopecks = (int)Math.Round((rounded-rubles) * 100);
            return $"{rubles} руб. {kopecks} коп.";
        }
    }

}
