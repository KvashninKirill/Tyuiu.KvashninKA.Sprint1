using Tyuiu.KvashninKA.Sprint1.Task7.V16.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task7.V16;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                            *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
        Console.WriteLine("* Задание #7                                                                                           *");
        Console.WriteLine("* Вариант #16                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных,         *");
        Console.WriteLine("* вводимых пользователем. Ответ округлите до 3 знаков после запятой.                                   *");
        Console.WriteLine("********************************************************************************************************");

        double x;

        Console.WriteLine("Введите значение х");
        x = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x);

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine($"* РЕЗУЛЬТАТ:                                                                                          *");
        Console.WriteLine("********************************************************************************************************");

        Console.WriteLine($"z = {res:f3}");

        Console.ReadLine();
    }
}