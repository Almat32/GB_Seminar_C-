
string[] FillDataArray(int size)  // Функция создает текстовый массив с указанием размера.
{
    string[] array = new string[size]; // текстовый массив с размером.
    for (int i = 0; i < array.Length; i++) // цикл for
    {   
        Console.WriteLine("Введите число для " + i + " индекса"); // выводит сообщение с указанием индекса.
        array[i] = Console.ReadLine(); // Ввод значении в массив.
    }
    return array; // Возвращает индекс.
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

void WriteArray(int[] array) // Функция выводит массив на экран.
{
    Console.WriteLine(String.Join(", ", array));
}

int[] MultipleNumber(int[] array, int multiple = 2) // функция кратности. Заводит значения в массив только с указанной кратностью 
{
    int index = 0;
    int[] testMulti = new int[array.Length]; // Тестовый массив.
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % multiple == 0)
        {
            index++;
            testMulti[i] = array[i];
        }
    }
    array = new int[index];
    for (int i = 0; i < index; i++)
    {
        array[i] = testMulti[i];
    }
    return array;
}

string[] NewArray = FillDataArray(8);
int[] numbers = ConvertArrayToint(NewArray);
WriteArray(numbers);
int[] MultipleTwoNumer = MultipleNumber(numbers);
int[] MultipleFiveNumer = MultipleNumber(numbers,5);
WriteArray(MultipleTwoNumer);
WriteArray(MultipleFiveNumer);
