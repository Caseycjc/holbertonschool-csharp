using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);

        set1.SymmetricExceptWith(set2);

        List<int> result = new List<int>(set1);

        for (int i = 0; i < result.Count - 1; i++)
        {
            for (int j = i + 1; j < result.Count; j++)
            {
                if (result[j] < result[i])
                {
                    int temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }

        return result;
    }
}
