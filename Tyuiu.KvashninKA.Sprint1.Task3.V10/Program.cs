
using Tyuiu.KvashninKA.Sprint1.Task3.V10.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task3.V10;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                            *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
        Console.WriteLine("* Задание #3                                                                                           *");
        Console.WriteLine("* Вариант #10                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                              *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                                          *");
        Console.WriteLine("********************************************************************************************************");

        Console.WriteLine("Введите дробное число");
        string input = Console.ReadLine().Replace('.', ',');
        double number = Convert.ToDouble(input);

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine($"* РЕЗУЛЬТАТ:                                                                                          *");
        Console.WriteLine("********************************************************************************************************");

        string result = ds.NumberToMoney(number);
        Console.WriteLine($"{number} руб. - это {result}");

        Console.ReadLine();
    }
}