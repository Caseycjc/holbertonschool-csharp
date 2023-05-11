using System;

class Program
{
    static void Main(string[] args)
    {
        char currentChar = 'a';

        do
        {
            if (currentChar != 'q' && currentChar != 'e')
            {
                Console.Write(currentChar);
            }

            currentChar++;
        } while (currentChar <= 'z');
    }
}
