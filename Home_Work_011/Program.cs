// Напишите цикл, который принимает на вход два число
// (А и B) и возводит число А в натуральную степень B.


int n = 2;//Переменная которая задает размер массива
int[] array = new int[n];//Задаем размер массива

for (int i = 0; i < n; i++)//Присваиваем значение каждой ячейки массива
{
    Console.WriteLine("Введите число:");
    int k = Int32.Parse(Console.ReadLine()); // Вводим значение
    array[i] = k;
    int A = array[0];
    int B = array[1];
    double step = Math.Pow(A,B);
    Console.WriteLine("Результат степени: " + (double)step);
}
