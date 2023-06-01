using System;

/// <summary>
/// The TestObject class that inherits from Base and implements IInteractive, IBreakable, and ICollectable interfaces.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Property representing the durability of an object.
    /// </summary>
    public int Durability { get; set; }

    /// <summary>
    /// Property indicating whether the object has been collected.
    /// </summary>
    public bool IsCollected { get; set; }

    /// <summary>
    /// Method for interaction.
    /// </summary>
    public void Interact()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Method for breaking the object.
    /// </summary>
    public void Break()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Method for collecting the object.
    /// </summary>
    public void Collect()
    {
        throw new NotImplementedException();
    }
}
