string[,] matrix = {{"-","-","-","-","-",},
                    {"-","-","-","-","-",},
                    {"-","|","@ ","-","-",},
                    {"-","-","-","-","-",},
                    {"-","-","-","-","$",},
                    {"-","-","-","-","-",},};
int coins = 0;
void MatrixWrite(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "-");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Кол-во " + coins);
}

string[,] ItemFoodMatrix(int x, int y, string[,] array)
{
    while(matrix[y,x] == "$")
    {
        matrix[y,x] = "-";
        int matX = new Random().Next(0, array.GetLength(1));
        int matY = new Random().Next(0, array.GetLength(0));
        while(matrix[matY,matX] == "|")
        {
            matX = new Random().Next(0, array.GetLength(1));
            matY = new Random().Next(0, array.GetLength(0));
        }
        array[matY,matX] = "$";
        coins++;
    }
    return array;
}

bool Barrier(int x, int y)
{
    if(matrix[y,x] == "|") return false;
    return true;
}

int x = 2;
int y = 2;
while (true)
{
    Console.Clear();
    MatrixWrite(matrix);
    matrix[y,x] = "-";
    ConsoleKeyInfo User_keyTab = Console.ReadKey();
    if(User_keyTab.Key == ConsoleKey.W) if(Barrier(x,y-1)) y--;
    if(User_keyTab.Key == ConsoleKey.S) if(Barrier(x,y+1)) y++;
    if(User_keyTab.Key == ConsoleKey.A) if(Barrier(x-1,y)) x--;
    if(User_keyTab.Key == ConsoleKey.D) if(Barrier(x+1,y)) x++;

    if(y >= matrix.GetLength(0)) y = 0;
    if(y <= 0) y = matrix.GetLength(0)-1;
    
    if(x >= matrix.GetLength(1)) x = 0;
    if(x <= 0) x = matrix.GetLength(1)-1;
    matrix = ItemFoodMatrix(x,y,matrix);
    matrix[y,x] = "@";
}
