/// <summary>
/// VectorMath Class
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a scalar and returns the resulting vector.
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        int dimensions = vector.Length;

        // Check if the vector is 2D or 3D
        if (dimensions != 2 && dimensions != 3)
        {
            return new double[] { -1 };
        }

        double[] result = new double[dimensions];

        // Multiply each component of the vector by the scalar
        for (int i = 0; i < dimensions; i++)
        {
            result[i] = vector[i] * scalar;
        }

        return result;
    }
}
