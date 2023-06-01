///<summary>
/// Matrixmath class
///</summary>

public class MatrixMath
{
    /// <summary>
    /// Adds two matrices and returns the resulting matrix.
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int columns2 = matrix2.GetLength(1);

        // Check if the matrices are both 2D or both 3D
        if ((rows1 != 2 && rows1 != 3) || (rows2 != 2 && rows2 != 3) || (columns1 != 2 && columns1 != 3) || (columns2 != 2 && columns2 != 3))
        {
            return new double[,] { { -1 } };
        }

        // Check if the matrices are of the same size
        if (rows1 != rows2 || columns1 != columns2)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows1, columns1];

        // Add the corresponding elements of the matrices
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns1; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
}
