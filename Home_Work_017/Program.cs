// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

using static System.Console;
Clear();

Write("Введите размер массива: ");
int[] parameter = GetParams(ReadLine());
int[] array = GetRandomArray(parameter[0]);
WriteLine(String.Join(", ", array));

int max = 0;
int min = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else
    {
        min = array[i];
    }
    

}
int raznica = max - min;
WriteLine($"Разница между максимальном и минимальным числом: {raznica}");

int[] GetParams(string inString)
{   
    string[] param = inString.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[param.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(param[i]);
    }
    return result;
}

int[] GetRandomArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0,999);
    }
    return result;
}

