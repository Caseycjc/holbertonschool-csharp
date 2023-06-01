using System;

/// <summary> VectorMath class </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the magnitude (length) of a given vector.
    /// </summary>
    public static double Magnitude(double[] vector)
    {
        int dimensions = vector.Length;

        // Check if the vector is 2D or 3D
        if (dimensions != 2 && dimensions != 3)
        {
            return -1;
        }

        double sumOfSquares = 0;

        // Calculate the sum of squares of vector components
        for (int i = 0; i < dimensions; i++)
        {
            sumOfSquares += Math.Pow(vector[i], 2);
        }

        double magnitude = Math.Sqrt(sumOfSquares);

        // Round the magnitude to the nearest hundredth
        magnitude = Math.Round(magnitude, 2);

        return magnitude;
    }
}
