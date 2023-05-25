using System;

/// <summary>
/// This class contains methods to check the type of objects.
/// </summary>
public class Obj
{
    /// <summary>
    /// Determines whether the provided object is an int.
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }

    /// <summary>
    /// Determines whether the provided object is an instance of, or an instance of a class that inherited from, Array.
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
