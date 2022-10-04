// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами. m = 3, n = 4



int[,] matrix = new int[3,4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(-999,999);
        Console.Write(matrix[i,j] + ", ");
    }
    Console.WriteLine();
}
