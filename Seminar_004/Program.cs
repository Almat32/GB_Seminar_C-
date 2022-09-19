int[] FillArrayNumber(int[] array) // функция создания массива рандомно
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void WriteArrayPrint(int[] array) // Функция печатания массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}
int[] numbers = FillArrayNumber(new int[8]); // создаем массив "numbers" вызывая функцию "FillArrayNumber" с указанием количства значения в массиве 
WriteArrayPrint(numbers); // Выводим на экран созданный массив