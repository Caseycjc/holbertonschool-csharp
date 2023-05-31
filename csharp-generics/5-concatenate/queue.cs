using System;

/// <summary>
/// Queue class.
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Node class.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// The value of the Node.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// The next Node in the Queue.
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Constructor that sets the value of the Node.
        /// </summary>
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    /// <summary>
    /// The head Node of the Queue.
    /// </summary>
    public Node Head { get; private set; }

    /// <summary>
    /// The tail Node of the Queue.
    /// </summary>
    public Node Tail { get; private set; }

    private int count;

    /// <summary>
    /// Constructor that initializes the Queue.
    /// </summary>
    public Queue()
    {
        Head = null;
        Tail = null;
        count = 0;
    }

    /// <summary>
    /// Method that returns the Queue's type.
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    // ...

    /// <summary>
    /// Method that concatenates all values in the Queue if the type is string or char.
    /// </summary>
    public string Concatenate()
    {
        if (Head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        Type type = CheckType();

        if (type != typeof(string) && type != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only");
            return null;
        }

        Node currentNode = Head;
        string result = "";

        while (currentNode != null)
        {
            result += currentNode.Value.ToString();
            currentNode = currentNode.Next;
        }

        return result;
    }
}
