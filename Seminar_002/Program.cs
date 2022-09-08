/* int[] number = new int[4];
int[] num = {1,2,3,4,5,6,7,8,9};
Console.WriteLine(num[3] + 100 * 2); */

 
/* Console.WriteLine("введите число ");
int num_user = int.Parse(Console.ReadLine());
int[] number = new int[num_user];
for (int i = 0; i < number.Length; i++)
{
    number[i] = new Random().Next(1,10);
}
Console.WriteLine(String.Join(" ", number));
int count = 0; 
for (int j = 0; j < number.Length; j++)
{
    if (number[j] % 3 ==0)
    {
        Console.WriteLine(number[j] + " ");
        count++;
    }
}
Console.WriteLine("Количество чисел кратная 3 = " + count); */

/* Console.WriteLine("введите число ");
int num_user = int.Parse(Console.ReadLine());
int[] number = new int[num_user];
for (int i = 0; i < number.Length; i++)
{
    number[i] = new Random().Next(1,10);
}
Console.WriteLine(String.Join(" ", number));

MultipleNumberArray(number, 4);

void MultipleNumberArray(int[] array, int multiple)
{
    int count = 0; 
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j] % multiple == 0)
        {
            Console.WriteLine(array[j] + " ");
            count++;
        }
    }
    Console.WriteLine("Количество чисел кратная " + multiple + " = " + count);
} */

Console.WriteLine("введите число ");
int num_user = int.Parse(Console.ReadLine());
int[] number = new int[num_user];
for (int i = 0; i < number.Length; i++)
{
    number[i] = new Random().Next(-999,999); Создает 
}
Console.WriteLine(String.Join(" ", number));

int max = number[0];
for (int i = 0; i < number.Length; i++)
{
    if(max < number[i])
    {
        max = number[i];
    }
}