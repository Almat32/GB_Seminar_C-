// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int[] ConvertArrayToint(string[] array) // Конвертирует массив string в int
{
    int[] numberArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        char c = array[i][0];
        if(!Char.IsDigit(c))
        {
            Console.WriteLine("Не верно введен массив, введите цифры");
            break;

        }
        else
        {
            numberArray[i] = Convert.ToInt32(array[i]);
        }
    }
    return numberArray;
}
void WriteArray(int[] array)
{
    Console.WriteLine(String.Join(",", array));
}

void WriteArrayPrint(int[] array) // Функция печатания массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

// Вводит значения в виде string
string num ="";
Console.Write("Введите число: ");
num = Console.ReadLine();
string[] numArray = new string[num.Length];
int counter = 0;

for (int i = 0; i < num.Length; i++) // переводит в массив
{
     numArray[i] = num.Substring(counter, 1); // 1 is split length
     counter++;
}


//Суммиует int массив 
int SUM(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return array;
    
}


int[] IntArray = ConvertArrayToint(numArray);
int summa = SUM(IntArray);
WriteArray(int summa);



