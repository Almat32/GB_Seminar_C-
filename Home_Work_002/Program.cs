Console.WriteLine("Введите первое значение ");
string numa = Console.ReadLine();
int a = Convert.ToInt32(numa);

Console.WriteLine("Введите второе значение ");
string numb = Console.ReadLine();
int b = Convert.ToInt32(numb);

Console.WriteLine("Введите третье значение ");
string numc = Console.ReadLine();
int c = Convert.ToInt32(numc);

int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine("Максимум " + (max));