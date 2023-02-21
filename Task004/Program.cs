// Напишите программу, которая заполнит спирально квадратный массив.


int Promt(string? msg)
{
    System.Console.Write(msg + "-> ");
    return int.Parse(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            System.Console.Write(array[i, x] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] FillArrayS(int[,] array, int m, int n)
{
    int p = 1;
    int x = 1;
    int y = 1;

    int c = array.GetLength(0) * array.GetLength(1);

    for (int i = 0; i < n - 1; i++)
    {
        array[0, i] = p;
        p++;
        while (p > c) return array;
    }
    for (int i = 0; i < m - 1; i++)
    {
        array[i, n - 1] = p;
        p++;
        while (p > c) return array;
    }
    for (int i = n - 1; i > 0; i--)
    {
        array[m - 1, i] = p;
        p++;
        while (p > c) return array;
    }
    for (int i = m - 1; i > 0; i--)
    {
        array[i, 0] = p;
        p++;
        while (p > c) return array;
    }

    while (p < c)
    {
        while (array[x, y + 1] == 0) // Right
        {
            array[x, y] = p;
            p++; y++;
        }
        while (array[x + 1, y] == 0) // Down
        {
            array[x, y] = p;
            p++; x++;
        }
        while (array[x, y - 1] == 0) // Left
        {
            array[x, y] = p;
            p++; y--;
        }
        while (array[x - 1, y] == 0) // Up
        {
            array[x, y] = p;
            p++; x--;
        }
    }
    array[x,y] = p;
    return array;

}




int m = Promt("Введите длину строк ");
int n = Promt("Введите длину столбцов ");
int[,] myArray = new int[m, n];
FillArrayS(myArray, m, n);
PrintArray(myArray);