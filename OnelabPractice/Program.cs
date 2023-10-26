using OnelabPractice;

int n = 8; 
List<int[]> solutions = EightQueensSolver.SolveQueens(n);
Console.WriteLine("Distinct solutions to the 8-queens puzzle:");
PrintSolutions(solutions);


static void PrintSolutions(List<int[]> solutions)
{
    foreach (var solution in solutions)
    {
        for (int i = 0; i < solution.Length; i++)
        {
            for (int j = 0; j < solution.Length; j++)
            {
                if (solution[i] == j)
                {
                    Console.Write("Q ");
                }
                else
                {
                    Console.Write(". ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}