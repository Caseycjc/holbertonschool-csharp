///<summary>
///matrixmath class
///</summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices and returns the resulting matrix.
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int columns2 = matrix2.GetLength(1);

        // Check if the matrices can be multiplied
        if (columns1 != rows2)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows1, columns2];

        // Multiply the matrices
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                for (int k = 0; k < columns1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }
}
