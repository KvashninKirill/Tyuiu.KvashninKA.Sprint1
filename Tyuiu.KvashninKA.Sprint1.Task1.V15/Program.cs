using Tyuiu.KvashninKA.Sprint1.Task1.V15.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task1.V15;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                            *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
        Console.WriteLine("* Задание #0                                                                                           *");
        Console.WriteLine("* Вариант #5                                                                                           *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                              *");
        Console.WriteLine("* вычисляет результат по формуле (4+2*x)/7 и печатает его на экране.                                   *");
        Console.WriteLine("********************************************************************************************************");

        double x;
        Console.WriteLine("Введите значение Х:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine($"* РЕЗУЛЬТАТ: {ds.Calculate(x)}                                                                        *");
        Console.WriteLine("********************************************************************************************************");

        Console.ReadLine();
    }
}
