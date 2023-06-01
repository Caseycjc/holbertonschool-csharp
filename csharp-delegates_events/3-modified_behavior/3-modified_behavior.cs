/// <summary>
/// Represents the strength of a modifier.
/// </summary>
public enum Modifier
{
    Weak,
    Base,
    Strong
}

/// <summary>
/// Delegate to calculate modified value.
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

public class ModifierUtility
{
    /// <summary>
    /// Applies a modifier to a base value.
    /// </summary>
    public static float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue / 2;
            case Modifier.Strong:
                return baseValue * 1.5f;
            case Modifier.Base:
            default:
                return baseValue;
        }
    }
}
