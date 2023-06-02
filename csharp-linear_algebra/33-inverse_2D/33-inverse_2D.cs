using System;

///<summary>
/// math class
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Calculates the inverse of a 2D matrix.
    /// </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        if (Math.Abs(determinant) < 0.0001)
        {
            return new double[,] { { -1 } };
        }

        double[,] inverse = new double[2, 2];
        inverse[0, 0] = Math.Round(matrix[1, 1] / determinant, 2);
        inverse[0, 1] = Math.Round(-matrix[0, 1] / determinant, 2);
        inverse[1, 0] = Math.Round(-matrix[1, 0] / determinant, 2);
        inverse[1, 1] = Math.Round(matrix[0, 0] / determinant, 2);

        return inverse;
    }
}
