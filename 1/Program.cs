using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число (A): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число (B): ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"{a} больше, чем {b}");
            Console.WriteLine($"{b} меньше, чем {a}");
        }
        else if (a < b)
        {
            Console.WriteLine($"{b} больше, чем {a}");
            Console.WriteLine($"{a} меньше, чем {b}");
        }
        else
        {
            Console.WriteLine($"{a} и {b} равны");
        }
    }
}
