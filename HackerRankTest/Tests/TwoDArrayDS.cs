using System;

namespace HackerRankTest.Tests
{
    public static class TwoDArrayDS
    {
        public static void Execute() 
        {
            int[][] matrix = LoadMatrix();
            PrintMatrix(matrix);

            Console.WriteLine("Sub sets");

            int? result = null;
            int subSetResult = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    var subMatrix = GetSubSet(matrix, row, col);
                    if (subMatrix != null)
                    {
                        PrintMatrix(subMatrix);
                        subSetResult = GetSum(subMatrix);
                        if (!result.HasValue || result.Value < subSetResult)
                        {
                            result = subSetResult;
                        }
                    }
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine($"Result: {result}");

        }

        private static void PrintMatrix(int[][] matrix) 
        {
            if (matrix != null)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        Console.Write($"{matrix[row][col]} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static int[][] GetSubSet(int[][] matrix, int row, int col)
        {
            int[][] result = new int[3][];
            int rowSubSet = 0;
            int colSubSet = 0;

            if ((row + 3 <= matrix.GetLength(0)) && (col + 3 <= matrix[row].Length))
            {
                for (int i = row; i < matrix.GetLength(0) && rowSubSet < result.GetLength(0); i++)
                {
                    result[rowSubSet] = new int[3];
                    for (int j = col; j < matrix[row].Length && colSubSet < result[rowSubSet].Length; j++)
                    {
                        result[rowSubSet][colSubSet] = matrix[i][j];
                        colSubSet++;
                    }
                    rowSubSet++;
                    colSubSet = 0;
                }
            }
            else {
                result = null;
            }

            return result;

        }

        private static int GetSum(int[][] matrix) 
        {
            int result = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if ((row == 1 && col == 0) || (row == 1 && col == 2))
                    {
                        result += 0;
                    }else
                    {
                        result += matrix[row][col];
                    }
                }
            }

            return result;
        }

        private static int[][] LoadMatrix()
        {
            int[][] result = new int[6][];

            result[0] = new int[6];
            result[0][0] = -9;
            result[0][1] = -9;
            result[0][2] = -9;
            result[0][3] = 1;
            result[0][4] = 1;
            result[0][5] = 1;

            result[1] = new int[6];
            result[1][0] = 0;
            result[1][1] = -9;
            result[1][2] = 0;
            result[1][3] = 4;
            result[1][4] = 3;
            result[1][5] = 2;

            result[2] = new int[6];
            result[2][0] = -9;
            result[2][1] = -9;
            result[2][2] = -9;
            result[2][3] = 1;
            result[2][4] = 2;
            result[2][5] = 3;

            result[3] = new int[6];
            result[3][0] = 0;
            result[3][1] = 0;
            result[3][2] = 8;
            result[3][3] = 6;
            result[3][4] = 6;
            result[3][5] = 0;

            result[4] = new int[6];
            result[4][0] = 0;
            result[4][1] = 0;
            result[4][2] = 0;
            result[4][3] = -2;
            result[4][4] = 0;
            result[4][5] = 0;

            result[5] = new int[6];
            result[5][0] = 0;
            result[5][1] = 0;
            result[5][2] = 1;
            result[5][3] = 2;
            result[5][4] = 4;
            result[5][5] = 0;

            /*result[0, 0] = 1;
            result[0, 1] = 1;
            result[0, 2] = 1;
            result[0, 3] = 0;
            result[0, 4] = 0;
            result[0, 5] = 0;

            result[1, 0] = 0;
            result[1, 1] = 1;
            result[1, 2] = 0;
            result[1, 3] = 0;
            result[1, 4] = 0;
            result[1, 5] = 0;

            result[2, 0] = 1;
            result[2, 1] = 1;
            result[2, 2] = 1;
            result[2, 3] = 0;
            result[2, 4] = 0;
            result[2, 5] = 0;

            result[3, 0] = 0;
            result[3, 1] = 0;
            result[3, 2] = 0;
            result[3, 3] = 0;
            result[3, 4] = 0;
            result[3, 5] = 0;

            result[4, 0] = 0;
            result[4, 1] = 0;
            result[4, 2] = 0;
            result[4, 3] = 0;
            result[4, 4] = 0;
            result[4, 5] = 0;

            result[5, 0] = 0;
            result[5, 1] = 0;
            result[5, 2] = 0;
            result[5, 3] = 0;
            result[5, 4] = 0;
            result[5, 5] = 0;*/
            return result;
            //return result;
            /*
            result[0,0] = 1;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col]} ");
                }
                Console.WriteLine();
            }*/

        }
    }
}
