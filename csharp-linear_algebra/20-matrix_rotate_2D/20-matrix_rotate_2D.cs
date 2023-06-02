using System;

///<summary>
/// math class
///</summary>
public class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        // Check if the matrix is square
        if (rows != columns)
        {
            return new double[,] { { -1 } };
        }

        // Check if the matrix is of a valid size
        if (rows != 2)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, columns];

        // Calculate the rotation
        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);

        // Apply rotation to each element in the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix[i, j] * cosAngle - matrix[i, (j + 1) % columns] * sinAngle;
            }
        }

        return result;
    }
}
