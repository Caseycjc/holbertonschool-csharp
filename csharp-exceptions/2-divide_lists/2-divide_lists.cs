using System;
using System.Collections.Generic;

public class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> sum = new List<int>();
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                sum.Add(div(list1[i], list2[i]));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return sum;
    }
    static int div(int a, int b)
    {
        int sum = 0;
        try
        {
            sum = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
            sum = 0;
        }
        return sum;
    }
}
