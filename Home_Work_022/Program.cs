// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите кол-во строк:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows,columns];
double[] sum = new double [rows];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = new Random().Next(1,9);
        Console.Write(matrix[i,j] + ", ");
    }
    Console.WriteLine();  
}

for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        sum[i] += matrix[i,j];
        
    }
    //Console.WriteLine(sum[i] + ", ");
}


for (int i = 0; i < columns; i++)
{
    //double[i] middleArray = sum[i] / rows; 
    Console.Write($"{sum[i] / rows:f1}" + " ");
}


