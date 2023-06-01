/// <summary>
/// The Base abstract class.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Converts the value of this instance to its equivalent string representation.
    /// </summary>
    public override string ToString()
    {
        return $"{Name} is a {GetType().Name}";
    }
}
