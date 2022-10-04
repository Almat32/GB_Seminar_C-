// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


using static System.Console;
Clear();

Write("Введите размер массива: ");
int[] parameter = GetParams(ReadLine());
int[] array = GetRandomArray(parameter[0]);
WriteLine(String.Join(", ", array));

int PositivNumber = 0;
int NegativeNumber = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        PositivNumber++;
    }
    else
    {
        NegativeNumber++;
    }

}
WriteLine($"количество чисел больше 0 = {PositivNumber}");

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
        result[i] = new Random().Next(-999,999);
    }
    return result;
}