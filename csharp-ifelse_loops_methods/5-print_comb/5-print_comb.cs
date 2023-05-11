using System;

class Program
{
    static void Main(string[] args)
    {
        string[] numbers = new string[100];
        
        for (int number = 0; number < 100; number++)
        {
            numbers[number] = number.ToString("00");
        }

        Console.Write(string.Join(", ", numbers));
    }
}
