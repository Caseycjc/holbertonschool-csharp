/// <summary>
/// The Base abstract class.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// public name
    /// </summary>
    public string name;

    /// <summary>
    /// Converts the value of this instance to its equivalent string representation.
    /// </summary>
    public override string ToString()
    {
        return string.Format("{0} is a {1}", name, this.GetType().ToString());
    }
}
