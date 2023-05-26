using System;
using System.Reflection;

/// <summary>
/// This class contains methods to check the type of objects.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        if (myObj == null)
        {
            Console.WriteLine("Object is null");
            return;
        }

        Type type = myObj.GetType();

        Console.WriteLine("Properties:");
        foreach (PropertyInfo property in type.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine("Methods:");
        foreach (MethodInfo method in type.GetMethods())
        {
            // Exclude system defined methods
            if (method.DeclaringType == typeof(object))
            {
                continue;
            }

            Console.WriteLine(method.Name);
        }
    }
}
