// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите число ОТ:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число ДО:");
int M = Convert.ToInt32(Console.ReadLine());

int SumRec(int M)

{
    if(M == N) return N;
    else return M + SumRec(M - 1);
    Console.WriteLine(M);
}

Console.WriteLine(SumRec(M));