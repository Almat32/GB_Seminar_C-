// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

string[] FillDataArray(int size)
{
    
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите значение в индекс: " + i);
        array[i] = Console.ReadLine();

    }
    return array;
}

int[] ConvertArrayToint(string[] array) // Функция конвертирует строковый массив в целочисленный. 
{
    int[] numberArray = new int[array.Length]; // массив с размером массива
    for (int i = 0; i < array.Length; i++)
    {
        char c = array[i][0]; // передаем с массива "array" первый элемент в переменнную char "с"
        if(!Char.IsDigit(c)) // если в char "c" нет букв, true или Falls
        {
            Console.WriteLine("Не верно введен массив, перепиши"); // Falls
            break; // останавливает цикл "for" если в массиве есть буква.
        }
        else // если в массиве цифры то конвертируем массив в int целочисленный
        {
            numberArray[i] = Convert.ToInt32(array[i]); // конвертирует значение из индекса в int целочисленное число. 
        }
    }
    return numberArray; // Возвращает индекс.
}
void WriteArray(int[] array)
{
    Console.WriteLine(String.Join(",", array));
}

string[] AR = FillDataArray(8);
int[]IntArray = ConvertArrayToint(AR);
WriteArray(IntArray);
