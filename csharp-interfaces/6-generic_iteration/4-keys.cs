using System;

/// <summary>
/// The Key class that inherits from Base and implements the ICollectable interface.
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Indicates whether this key has been collected.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Key"/> class.
    /// </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Collects the key, setting its status to collected and printing a message to the console.
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}
