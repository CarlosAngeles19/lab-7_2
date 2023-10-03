using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Divisores de Omar Orlandini:");

        for (int i = 1; i <= 1000; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("Divisor de Omar Orlandini " + (i / 3) + ": " + i);
            }
        }
    }
}
