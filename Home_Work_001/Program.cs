Console.WriteLine("Введите первое значение ");
string na = Console.ReadLine();
int a = Convert.ToInt32(na);

Console.WriteLine("Введите второе значение ");
string nb= Console.ReadLine();
int b = Convert.ToInt32(nb);

if(a > b)
{
    Console.WriteLine("Максимум " + (a));
    Console.WriteLine("Минимум " + (b));
}
else
{
    Console.WriteLine("Максимум " + (b));
    Console.WriteLine("Минимум " + (a));
}
