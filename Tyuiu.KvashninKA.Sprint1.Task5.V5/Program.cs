
using Tyuiu.KvashninKA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task5.V5;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                            *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
        Console.WriteLine("* Задание #5                                                                                           *");
        Console.WriteLine("* Вариант #5                                                                                           *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Присвоить целой переменной d первую цифру из дробной части положительного                            *");
        Console.WriteLine("* вещественного числа x (так, если x=32.597, то d=5).                                                  *");
        Console.WriteLine("********************************************************************************************************");

        double x;
        Console.WriteLine("Введите число X");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine($"* РЕЗУЛЬТАТ:                                                                                          *");
        Console.WriteLine("********************************************************************************************************");

        Console.WriteLine($" Прервая цифра дробной части = {ds.Calculate(x)}");

        Console.ReadLine();
    }
}