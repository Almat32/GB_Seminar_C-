// Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]
// Найдите суму отрицательных и положительных элементов массива.

using static System.Console;
Clear();

Write("Введите размер массива, min, max через пробел: ");
int[] parameters = GetParams(ReadLine());
int[] array = GetArray(parameters[0], parameters[1], parameters[2]);
WriteLine(String.Join(", ", array));

int negativeSum = 0;
int positiveSum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        negativeSum += array[i];
    }
    else
    {
        positiveSum += array[i];
    }
}
WriteLine($"Сумма отрицательных чисел = {negativeSum}, сумма положительных = {positiveSum}");



// Метод принимающий параметры и ковертируйщий в int
int[] GetParams(string inString)
{
    string[] param = inString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[param.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(param[i]);    
    }
    return result;
}


// Метод формирующий массив случайных чисел с указанием диапазона
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}
