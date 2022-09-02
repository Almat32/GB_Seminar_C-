/* // типы данных, название и данные
int = 10; // int - целочисленные данные
float b = 12.4f; // - float дробный числа
double c = 8.4; // double дробный числа
string d = "Hello World"; //  string - строковые данные
bool e = true // false // bool данные с условием тое есть истина или ложь */


/* Console.WriteLine("Введите имя ");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name  + 2);
int number = Convert.ToInt32(name);
Console.WriteLine("Hello " + (number  + 2)); */

Console.WriteLine("Введите имя ");
string name = Console.ReadLine();
int number = Convert.ToInt32(name);
int secretNumber = 7;
if(number > secretNumber)
{
    Console.WriteLine("Серктеное число меньше");
}
else if(number < secretNumber)
{
    Console.WriteLine("Серктеное число больше");
}
else
{
    Console.WriteLine("Мы угадали");
}