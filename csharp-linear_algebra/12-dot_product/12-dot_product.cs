///<summary>
/// Math Class
///</summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int dimensions1 = vector1.Length;
        int dimensions2 = vector2.Length;

        // Check if the vectors are both 2D or both 3D
        if ((dimensions1 != 2 && dimensions1 != 3) || (dimensions2 != 2 && dimensions2 != 3))
        {
            return -1;
        }

        // Check if the vectors are of the same size
        if (dimensions1 != dimensions2)
        {
            return -1;
        }

        double dotProduct = 0;

        // Calculate the dot product by multiplying corresponding components and summing them
        for (int i = 0; i < dimensions1; i++)
        {
            dotProduct += vector1[i] * vector2[i];
        }

        return dotProduct;
    }
}
