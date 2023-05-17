using System;
using System.Collections.Generic;

public class ListHelper
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        try
        {
            for (int i = 0; i < n; i++)
            {
                if (i < myList.Count)
                {
                    Console.WriteLine(myList[i]);
                    count++;
                }
                else
                {
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        return count;
    }
}
