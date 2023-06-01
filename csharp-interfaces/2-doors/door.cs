using System;

/// <summary>
/// The Door class that inherits from Base and implements the IInteractive interface.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Door"/> class.
    /// </summary>
    /// <param name="name">The name of the door. If not provided, the name defaults to "Door".</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interacts with the door, printing a message to the console.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
