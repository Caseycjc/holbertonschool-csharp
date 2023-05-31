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
    /// Method that adds a new Node to the Queue.
    /// </summary>
    public void Enqueue(T value)
    {
        Node node = new Node(value);

        if (Head == null)
        {
            Head = node;
            Tail = node;
        }
        else
        {
            Tail.Next = node;
            Tail = node;
        }

        count++;
    }

    /// <summary>
    /// Method that removes the first Node from the Queue and returns its value.
    /// </summary>
    public T Dequeue()
    {
        if (Head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = Head.Value;
        Head = Head.Next;

        if (Head == null)
        {
            Tail = null;
        }

        count--;

        return value;
    }

    /// <summary>
    /// Method that returns the value of the first Node in the Queue without removing it.
    /// </summary>
    public T Peek()
    {
        if (Head == null)
        {
            Console.WriteLine("Queue is empty.");
            return default(T);
        }

        return Head.Value;
    }

    /// <summary>
    /// Method that returns the count of Nodes in the Queue.
    /// </summary>
    public int Count()
    {
        return count;
    }
}
