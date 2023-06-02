using System;

///<summary>
/// mathclass
///</summary>
public class MatrixMath
{
    /// <summary>
    /// Transposes a 2D matrix.
    /// </summary>

    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Create a new matrix with the dimensions of the input matrix transposed.
        double[,] transposedMatrix = new double[cols, rows];

        // Swap the row and column indices to transpose the matrix.
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        return transposedMatrix;
    }
}
