using System;
using System.Collections.Generic;

/// <summary>
/// The RoomObjects class that contains a method to interact with a list of objects.
/// </summary>
public class RoomObjects
{
    /// <summary>
    /// Iterates over a list of objects, interacting with them based on their interfaces.
    /// </summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var obj in roomObjects)
        {
            if (type == typeof(IInteractive) && obj is IInteractive interactive)
            {
                interactive.Interact();
            }
            else if (type == typeof(IBreakable) && obj is IBreakable breakable)
            {
                breakable.Break();
            }
            else if (type == typeof(ICollectable) && obj is ICollectable collectable)
            {
                collectable.Collect();
            }
        }
    }
}
