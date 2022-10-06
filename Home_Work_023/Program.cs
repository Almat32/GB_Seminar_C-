// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int a = 2;
string NumbersRec(int a, int N)
{
    if(a <= N) return NumbersRec(a + 1, N) + $"{a} ";
    else return String.Empty;
}
Console.WriteLine(NumbersRec(a, N));