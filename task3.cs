using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        double sum = Convert.ToDouble(Console.ReadLine());

        if (sum < 100)
        {
            sum += sum * 0.05;
        }
        else if (sum <= 200)
        {
            sum += sum * 0.07;
        }
        else
        {
            sum += sum * 0.10;
        }

        Console.WriteLine("Итоговая сумма: " + sum);
    }
}
