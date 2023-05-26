using System;

/// <summary>
/// rectangle class that inherits from shape
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// gets or sets the width of the rectangle
    /// </summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }

            width = value;
        }
    }

    /// <summary>
    /// gets or sets the height of the rectangle
    /// </summary>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }

            height = value;
        }
    }
}
