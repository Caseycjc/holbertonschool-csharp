using System;
using System.Collections.Generic;

public class Dictionary
{
    public static string BestScore(Dictionary<string, int> myDict)
    {
        if (myDict.Count == 0)
        {
            return "None";
        }

        string maxKey = null;
        int maxValue = -1;

        foreach (var pair in myDict)
        {
            if (pair.Value > maxValue)
            {
                maxValue = pair.Value;
                maxKey = pair.Key;
            }
        }

        return maxKey;
    }
}
