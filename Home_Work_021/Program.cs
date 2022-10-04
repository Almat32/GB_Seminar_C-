// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
using static System.Console;
Clear();

WriteLine("ВВедите номер строки");
int rows = Convert.ToInt32(Console.ReadLine());
WriteLine("ВВедите номер столбца");
int columns = Convert.ToInt32(Console.ReadLine());
int [,]UserArray = new int [rows,columns];

int[,] matrix = new int[3,4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,9);
        Write(matrix[i,j]+ ", ");
    }
    WriteLine();
}
if
{
    WriteLine("такого адреса нету");
}
else
{
    Console.WriteLine(String.Join(",", rows,columns));
}
