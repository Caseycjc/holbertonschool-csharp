using System;

/// <summary> queue class </summary>
public class Queue<T>
{

    /// <summary> returns the queues type </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

}
