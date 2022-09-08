/* Console.WriteLine("Введите трех значное число ");

int firstNumbr = int.Parse(Console.ReadLine());
int sep1 = firstNumbr % 1000; // 100;
int sep2 = firstNumbr % 100; // 10;
int sep3 = firstNumbr % 10;
Console.WriteLine(sep1);
Console.WriteLine(sep2);
Console.WriteLine(sep3); */

Console.WriteLine("Введите трех значное число ");

int firstNumbr = int.Parse(Console.ReadLine());
int sep1 = firstNumbr  / 100;
int sep2 = firstNumbr % 100;
int sep3 = firstNumbr % 10;
int sep4 = sep2 % 10;
Console.WriteLine(sep4 - 1);

