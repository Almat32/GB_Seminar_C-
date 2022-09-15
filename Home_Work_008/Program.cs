string number ="";
string numberBack = "";
int index = 0;
Console.WriteLine("Введите пяти значное число");
number = Console.ReadLine();

while (number.Length > 5)
{
    Console.WriteLine("Введенное число имеет больше пяти цифр");
}

index = number.Length - 1;
while (index >= 0)
{
    numberBack += number.Substring(index, 1);
    index--;
}

if (number == numberBack)
{
    Console.WriteLine("Это число является палиндромом");
}
else
{
    Console.WriteLine("Это число не является палиндромом");
}
Console.WriteLine();
