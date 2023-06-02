using System;

///<summary>
/// math class
///</summary>

public class MatrixMath
{
    /// <summary>
    /// Rotates each individual value in a 2D square matrix around 0 by a given angle in the complex plane.
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is square.
        if (rows != cols)
        {
            return new double[1, 1] { { -1 } };
        }

        double[,] rotatedMatrix = new double[rows, cols];

        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        // Rotate each element of the matrix.
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Consider each double in the input matrix as the real part of a complex number.
                double realPart = matrix[i, j];
                double imaginaryPart = 0;

                // Rotate the complex number by multiplying it with (cos(θ) + i*sin(θ)).
                double rotatedRealPart = realPart * cosTheta - imaginaryPart * sinTheta;
                //double rotatedImaginaryPart = realPart * sinTheta + imaginaryPart * cosTheta;

                // Store the real part of the rotated complex number, rounded to the nearest hundredth.
                rotatedMatrix[i, j] = Math.Round(rotatedRealPart, 2);
            }
        }

        return rotatedMatrix;
    }
}
