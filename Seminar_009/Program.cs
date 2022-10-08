/* 
Dictionary<int, string> dayweek = new Dictionary<int, string>()
{
    {1, "Понедельник, рабочий день"},
    {2, "Вторник, рабочий день"},
    {3, "Среда, рабочий день"},
    {4, "Четверг, рабочий день"},
    {5, "Пятница, рабочий день"},
    {6, "Суббота, выходной день"},
    {7, "Воскресенье, выходной день"},
};
Console.WriteLine("Введите число дня недели от 1 до 7");
int day = int.Parse(Console.ReadLine());
string week = dayweek[day];
Console.WriteLine("Это " + week + "!"); */

// Сумирование введенных цифр
/* int SubNumber(int number)
{
    if(number == 0) return 0;
    return number % 10 + SubNumber(number/10); // 234 - 4 23 - 3 2 - 2 0 = 0 
}
int i = SubNumber(int.Parse(Console.ReadLine()));
Console.WriteLine(i); */

int SubNumber(int number)
{
    if(number == 0) return 0;
    return number % 10 + SubNumber(number/10); // 234 - 4 23 - 3 2 - 2 0 = 0 
}
int Pow(int number, int rang)
{
    if(rang == 0) return 1;
    if(rang == 1) return number;
    return number * Pow(number, rang-1);
}
int x= Pow(2,2);
Console.WriteLine(x);