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
                int divisor = (i < list2.Count) ? list2[i] : 0; // Default divisor to 0 if out of range

                if (i < list1.Count)
                {
                    if (divisor != 0)
                    {
                        resultList.Add(dividend / divisor);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                        resultList.Add(0);
                    }
                }
                else if (list2.Count > 0) // Add zeroes only if list1 is empty and list2 is non-empty
                {
                    Console.WriteLine("Out of range");
                    resultList.Add(0);
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
