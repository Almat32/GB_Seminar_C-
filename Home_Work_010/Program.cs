// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до N

int number = new Random().Next(1,9);           // создает рандомно массив от 1 до 9 в переменную number
int[] array = new int[1];                      // создает новый массив с индексом 1 и присваевает имя array
for (int i = 1; i < number; i++)               // цикл for 
{
    int[] newArray = array;
    array = new int[array.Length+1];
    for (int j = 0; j < newArray.Length; j++)
    {
        array[j] = newArray[j];
    }
    if(i*i %5==0)
    {
        array[array.Length-1] = i*i;
    }
    System.Console.WriteLine(i*i);
}
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine(array[i]);
}

