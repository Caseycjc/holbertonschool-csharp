using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// The Objs class that is a collection of objects of type T.
/// </summary>
public class Objs<T> : IEnumerable<T>
{
    /// <summary>
    /// The internal list of objects.
    /// </summary>
    private List<T> objects;

    /// <summary>
    /// Initializes a new instance of the <see cref="Objs{T}"/> class.
    /// </summary>
    public Objs()
    {
        this.objects = new List<T>();
    }

    /// <summary>
    /// Adds an object to the collection.
    /// </summary>
    /// <param name="obj">The object to add.</param>
    public void Add(T obj)
    {
        this.objects.Add(obj);
    }

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    public IEnumerator<T> GetEnumerator()
    {
        return this.objects.GetEnumerator();
    }

    /// <summary>
    /// Returns an enumerator that iterates through a collection.
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
