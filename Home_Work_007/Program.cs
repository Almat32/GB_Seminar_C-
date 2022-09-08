// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели ");
int day = int.Parse(Console.ReadLine());
if(day < 8 && day > 0)
{
    if(day == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
else
{
    Console.WriteLine("Введенное число больше дней в неделе");
}