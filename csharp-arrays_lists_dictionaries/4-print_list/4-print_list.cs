using System;
using System.Collections.Generic;

public class ListCreator
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        
        List<int> list = new List<int>();
        
        for (int i = 0; i < size; i++)
        {
            list.Add(i);
            Console.Write(i + (i != size - 1 ? " " : ""));
        }

        Console.WriteLine();
        
        return list;
    }
}
