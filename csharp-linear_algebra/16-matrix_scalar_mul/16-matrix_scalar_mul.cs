///<summary>
/// matrixmath class
///</summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix by a scalar and returns the resulting matrix.
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        // Check if the matrix is 2D or 3D
        if ((rows != 2 && rows != 3) || (columns != 2 && columns != 3))
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, columns];

        // Multiply each element of the matrix by the scalar
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }
}
