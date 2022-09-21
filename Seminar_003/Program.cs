/* double a = Math.Pow(34,5); // возведение в степень
a = Math.Sqrt(a); // квадратный корень
a = Math.Round(a,2); // сколько знаком после запятых
System.Console.WriteLine(a); */


/* Console.WriteLine("Введите X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
Console.WriteLine($"d={d:f3}"); */

// Напишите программу, которая принимает на вход числоо (N)
// и выдает таблицу квадратов чисел от 1 до N

int number = new Random().Next(1,999);
int[] array = new int[1];
for (int i = 1; i < number; i++)
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


// Максимальное число в массиве
/* int[] array = new int[new Random().Next(1,1000)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-1000,1000);
}
int max = 0;
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
    if(array[i] > max)
    {
        max = array[i];
    }
}
System.Console.WriteLine("Самое большое число = " + max);  */