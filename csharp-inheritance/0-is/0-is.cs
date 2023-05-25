using System;

    /// <summary>
    /// determines if the provided object is an int
    /// </summary>
public class Obj
{
    /// <summary>
    /// bool prototype
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
