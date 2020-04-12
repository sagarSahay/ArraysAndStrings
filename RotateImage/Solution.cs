namespace RotateImage
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            var row = matrix.Length;
            var column = matrix[0].Length;
            // Transpose the matrix
            for (int i = 0; i < row; i++)
            {
                for (int j = i; j < column; j++)
                {
                    var temp = matrix[j][i];
                    matrix[j][i] = matrix[i][j];
                    matrix[i][j] = temp;
                }
            }
            
            // Reverse matrix
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column/2; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[i][column - j - 1];
                    matrix[i][column - j - 1] = temp;
                }
            }
        }
    }
}