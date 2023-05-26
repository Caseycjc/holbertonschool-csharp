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
        string className = myObj.GetType().Name;

        Console.WriteLine("{0} Properties:", className);
        foreach (var item in myObj.GetType().GetProperties())
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("{0} Methods:", className);
        foreach (var item in myObj.GetType().GetMethods())
        {
            Console.WriteLine(item.Name);
        }
    }
}
