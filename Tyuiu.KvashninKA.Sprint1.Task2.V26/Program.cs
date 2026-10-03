using Tyuiu.KvashninKA.Sprint1.Task2.V26.Lib;
namespace Tyuiu.KvashninKA.Sprint1.Task2.V26;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                            *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
        Console.WriteLine("* Задание #2                                                                                           *");
        Console.WriteLine("* Вариант #26                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Задано текущее время в часах и минутах. Вычислить, сколько минут прошло с начала суток.              *");
        Console.WriteLine("********************************************************************************************************");

        Console.WriteLine("Введите кол-во часов");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите кол-во минут");
        int minutes = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine($"* РЕЗУЛЬТАТ:                                                                                          *");
        Console.WriteLine("********************************************************************************************************");

        int res = ds.CalculateMinutesSinceStart(hours, minutes);
        Console.WriteLine("Кол-во минут с начала суток" + res);

        Console.ReadLine();
    }
}
