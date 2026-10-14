
using Tyuiu.KvashninKA.Sprint1.Task4.V1.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task4.V1;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                            *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
        Console.WriteLine("* Задание #4                                                                                           *");
        Console.WriteLine("* Вариант #1                                                                                           *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                              *");
        Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                                             *");
        Console.WriteLine("********************************************************************************************************");

        int x;
        Console.WriteLine("Введите число X");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine($"* РЕЗУЛЬТАТ:                                                                                          *");
        Console.WriteLine("********************************************************************************************************");

       Console.WriteLine($"1 / (x+2)^2 = {ds.Calculate(x):f3}");

        Console.ReadLine();
    }
}