using System;

class Program
{
    static void Main(string[] args)
    {
        for (int number = 0; number < 100; number++)
        {
            Console.Write(number.ToString("00") + (number < 99 ? ", " : ""));
        }
    }
}
