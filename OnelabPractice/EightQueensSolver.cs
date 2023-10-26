using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelabPractice
{
    public class EightQueensSolver
    {
        public static List<int[]> SolveQueens(int n)
        {
            List<int[]> solutions = new();
            int[] board = new int[n];

            SolveQueensUtil(n, 0, board, solutions);
            return solutions;
        }

        private static void SolveQueensUtil(int n, int row, int[] board, List<int[]> solutions)
        {
            if (row == n)
            {
                int[] solution = new int[n];
                Array.Copy(board, solution, n);
                solutions.Add(solution);
            }
            else
            {
                for (int col = 0; col < n; col++)
                {
                    if (IsSafe(board, row, col))
                    {
                        board[row] = col;
                        SolveQueensUtil(n, row + 1, board, solutions);
                        board[row] = -1;
                    }
                }
            }
        }

        private static bool IsSafe(int[] board, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (board[i] == col || Math.Abs(board[i] - col) == Math.Abs(i - row))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
