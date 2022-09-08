// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трех значное число ");
string Numbr = Console.ReadLine();

if(Numbr.Length != 3)
{
    Console.WriteLine("Количество cимволов не равна 3");
}
else
{   
    int num = int.Parse(Numbr);
    Console.WriteLine("второй символ: " + Numbr[1]);
    
}
