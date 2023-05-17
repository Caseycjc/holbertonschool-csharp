using System;
using System.Collections.Generic;

public class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> resultList = new List<int>();

        try
        {
            for (int i = 0; i < listLength; i++)
            {
                int dividend = (i < list1.Count) ? list1[i] : 0;
                int divisor = (i < list2.Count) ? list2[i] : 0;

                if (i < list2.Count)
                {
                    if (divisor != 0)
                    {
                        resultList.Add(dividend / divisor);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                }
                else
                {
                    Console.WriteLine("Out of range");
                }
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Out of range");
        }

        return resultList;
    }
}
