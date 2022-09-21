// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных


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
    Chet++;
}
else
{
    neChet++;
}
WriteLine($"количество четных чисел = {Chet}, количесвто не четных чисел = {neChet} ");

}

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
        result[i] = new Random().Next(100,999);
    }
    return result;
}
