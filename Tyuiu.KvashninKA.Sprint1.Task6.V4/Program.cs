using Tyuiu.KvashninKA.Sprint1.Task6.V4.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task6.V4;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                            *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
        Console.WriteLine("* Задание #6                                                                                           *");
        Console.WriteLine("* Вариант #4                                                                                           *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова, содержащие                      *");
        Console.WriteLine("* удвоенное н (\"нн\").                                                                                *");
        Console.WriteLine("********************************************************************************************************");

        string str;
        Console.WriteLine("");
        str = Console.ReadLine();
        string res = ds.CheckDoubleN(str);

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine($"* РЕЗУЛЬТАТ:                                                                                          *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine(res);

        Console.ReadLine();
    }
}