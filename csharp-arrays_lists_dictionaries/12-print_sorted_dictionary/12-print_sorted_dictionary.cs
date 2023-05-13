using System;
using System.Collections.Generic;
using System.Linq;

public class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        foreach (var pair in myDict.OrderBy(pair => pair.Key))
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
