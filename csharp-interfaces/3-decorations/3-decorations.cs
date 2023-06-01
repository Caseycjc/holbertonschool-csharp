using System;

/// <summary>
/// The Decoration class that inherits from Base and implements the IInteractive and IBreakable interfaces.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Gets or sets a value indicating whether this decoration is a quest item.
    /// </summary>
    public bool IsQuestItem { get; set; }

    /// <summary>
    /// Gets or sets the durability of this decoration.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Decoration"/> class.
    /// </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0", nameof(durability));
        }

        this.name = name;
        Durability = durability;
        IsQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interacts with the decoration, printing a message to the console depending on its properties.
    /// </summary>
    public void Interact()
    {
        if (Durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (IsQuestItem)
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
        Durability--;

        if (Durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (Durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}
