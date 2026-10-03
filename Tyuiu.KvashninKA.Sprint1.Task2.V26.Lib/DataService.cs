using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KvashninKA.Sprint1.Task2.V26.Lib
{
    public class DataService : ISprint1Task2V26
    {
        public int CalculateMinutesSinceStart(int hours, int minutes)
        {
            return hours * 60 + minutes;
        }
    }

}