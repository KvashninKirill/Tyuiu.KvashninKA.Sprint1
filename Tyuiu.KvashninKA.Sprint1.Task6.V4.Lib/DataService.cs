using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KvashninKA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string[] words = value.Split(' ');
            string res = "";

            foreach (string word in words)
            {
                if (word.Contains("нн"))
                {
                    if (string.IsNullOrEmpty(res))
                    {
                        res = word;
                    }
                    else
                    {
                        res += " " + word;
                    }
                }
            }

            return res;

        }
    }

}