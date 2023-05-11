using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;

        for (int i = 0; i <= 8; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                count++;
                Console.Write($"{i}{j}");

                // Check if it's not the last combination
                if (count < 36)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
