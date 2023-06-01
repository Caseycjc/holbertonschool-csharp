using System;

/// <summary>
/// The Decoration class that inherits from Base and implements the IInteractive and IBreakable interfaces.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Indicates whether this decoration is a quest item.
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// Gets or sets the durability of this decoration.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Decoration"/> class.
    /// </summary>
    /// <param name="name">The name of the decoration. If not provided, defaults to "Decoration".</param>
    /// <param name="durability">The durability of the decoration. If not provided, defaults to 1. If 0 or less, an exception is thrown.</param>
    /// <param name="isQuestItem">A value indicating whether this decoration is a quest item. If not provided, defaults to false.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0", nameof(durability));
        }

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interacts with the decoration, printing a message to the console depending on its properties.
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Breaks the decoration, decrementing its durability and printing a message to the console.
    /// </summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}
