using System;

///<summary>
/// math class
///</summary>
public class MatrixMath
{
    /// <summary>
    /// Shears a 2D square matrix by a given shear factor in the specified direction.
    /// </summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is square.
        if (rows != cols)
        {
            return new double[1, 1] { { -1 } };
        }

        double[,] shearedMatrix = new double[rows, cols];

        // Perform the shearing transformation.
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (direction == 'x')
                {
                    // Shear in the x direction: (x, y) -> (x + factor * y, y)
                    shearedMatrix[i, j] = matrix[i, j] + factor * i;
                }
                else if (direction == 'y')
                {
                    // Shear in the y direction: (x, y) -> (x, y + factor * x)
                    shearedMatrix[i, j] = matrix[i, j] + factor * j;
                }
                else
                {
                    // Invalid direction.
                    return new double[1, 1] { { -1 } };
                }
            }
        }

        return shearedMatrix;
    }
}
