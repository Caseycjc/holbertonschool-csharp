using System;

public class Obj
{
    /// <summary>
    /// determines if the provided object is an int
    /// </summary>
    /// <param name="obj">the object to check</param>
    /// <returns>rue if the object is an int, false otherwise</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
