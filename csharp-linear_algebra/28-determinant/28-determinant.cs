using System;

///<summary>
/// math class
///</summary>

public class MatrixMath
{
    /// <summary>
    /// Calculates the determinant of a 2D or 3D matrix.
    /// </summary>
    public static double Determinant(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return -1;
        }
        
        if (rows == 2)
        {
            // Calculate the determinant of a 2D matrix.
            return Math.Round((matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]), 2);
        }
        else if (rows == 3)
        {
            // Calculate the determinant of a 3D matrix.
            return Math.Round((matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                 - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                 + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0])), 2);
        }
        else
        {
            // The matrix is not 2D or 3D.
            return -1;
        }
    }
}
