using System;

/// <summary>
/// This class contains methods to check the type of objects.
/// </summary>
public class Obj
{
    /// <summary>
    /// Determines whether the provided derivedType is a subclass of the specified baseType.
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return baseType.IsAssignableFrom(derivedType) && derivedType != baseType;
    }
}
