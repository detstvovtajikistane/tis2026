using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a == b)
            Console.WriteLine("Числа равны");
        else if (a > b)
            Console.WriteLine("Первое число больше второго");
        else
            Console.WriteLine("Первое число меньше второго");
    }
}
