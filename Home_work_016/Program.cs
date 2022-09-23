// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

using static System.Console;
Clear();

Write("Введите размер массива: ");
int[] parameter = GetParams(ReadLine());
int[] array = GetRandomArray(parameter[0]);
WriteLine(String.Join(", ", array));

int Chet = 0;
int neChet = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        Chet += array[i];
    }
    else
    {
        neChet += array[i];
    }

}
WriteLine($" Сумма не четных чисел = {neChet} ");

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

