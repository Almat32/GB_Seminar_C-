// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трех занчное число");
string number = Console.ReadLine();
if(number.Length > 2)
{
    string StrNum = number.Substring(2,1);
    int num = int.Parse(StrNum);
    Console.WriteLine("Значение третьего индекса: " + number[2]);
    
}

else
{
    
    Console.WriteLine("третьей строки нету");
}