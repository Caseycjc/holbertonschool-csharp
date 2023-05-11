using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 9; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                Console.Write($"{i}{j}, ");
            }
        }

        Console.WriteLine();
    }
}
