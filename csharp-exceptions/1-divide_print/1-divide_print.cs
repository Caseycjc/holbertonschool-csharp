using System;
using System.Collections.Generic;

public class Int
{
    public static void divide(int a, int b)
    {
        try
        {
        int result = a / b;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero");
        }
        finally
        {
            Console.WriteLine("Cleanup tasks are performed here.");
        }
    }
    
}
