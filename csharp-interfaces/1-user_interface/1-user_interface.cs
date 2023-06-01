/// <summary>
/// Interface for interactive objects.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Method to be implemented for interaction.
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface for breakable objects.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Property representing the durability of an object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Method to be implemented for breaking an object.
    /// </summary>
    void Break();
}

/// <summary>
/// Interface for collectable objects.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Property indicating whether the object has been collected.
    /// </summary>
    bool IsCollected { get; set; }

    /// <summary>
    /// Method to be implemented for collecting an object.
    /// </summary>
    void Collect();
}
