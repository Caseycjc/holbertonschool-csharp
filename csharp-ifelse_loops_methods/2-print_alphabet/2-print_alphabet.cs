using System;

class Program
{
    static void Main(string[] args)
    {
        char currentChar = 'a';
        
        do
        {
            Console.Write(currentChar);
            currentChar++;
        } while (currentChar <= 'z');
    }
}
