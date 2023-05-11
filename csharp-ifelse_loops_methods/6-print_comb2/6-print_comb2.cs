using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;

        for (int i = 0; i <= 9; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                Console.Write($"{i}{j}");

                count++;

                if (count < 45)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}

