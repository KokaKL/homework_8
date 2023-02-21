// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Promt(string? msg)
{
    System.Console.Write(msg + "-> ");
    return int.Parse(Console.ReadLine());
}

int[,] CreateArray(int m, int n)
{
    Random rnd = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            array[i, x] = rnd.Next(1, 10);
        }
    }
    return array;
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

int[,] Sort(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int z = 0; z < array.GetLength(1); z++)
        {
            for (int j = 0; j < array.GetLength(1) - 1 ; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
        }
    }
    return array;
}


int m = Promt("Введите длину строк ");
int n = Promt("Введите длину столбцов ");
int[,] myArray = CreateArray(m, n);
PrintArray(myArray);
System.Console.WriteLine();
Sort(myArray);
PrintArray(myArray);
System.Console.WriteLine();