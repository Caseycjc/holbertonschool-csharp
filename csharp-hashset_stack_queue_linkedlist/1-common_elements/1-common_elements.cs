using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);

        List<int> common = new List<int>();
        
        foreach (var item in set1)
        {
            if (set2.Contains(item))
            {
                common.Add(item);
            }
        }

        for (int i = 0; i < common.Count - 1; i++)
        {
            for (int j = i + 1; j < common.Count; j++)
            {
                if (common[j] < common[i])
                {
                    int temp = common[i];
                    common[i] = common[j];
                    common[j] = temp;
                }
            }
        }

        return common;
    }
}
