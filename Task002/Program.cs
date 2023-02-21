// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] Sum(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int z = 0; z < array.GetLength(1); z++)
        {
            sum = sum + array[i, z];
        }
        arr[i] = sum;
        sum = 0;
    }
    return arr;
}

void MinString(int[] array)
{
    int min = array[0];
    int res = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            res = i + 1;
        }
    }
    System.Console.WriteLine("Строка с минимальной суммой: " + res);
}

int m = Promt("Введите длину строк ");
int n = Promt("Введите длину столбцов ");
int[,] myArray = CreateArray(m, n);
PrintArray(myArray);
System.Console.WriteLine();
int[] resultArray = Sum(myArray);
foreach (var item in resultArray)
{
    System.Console.Write(item + "; ");
}
System.Console.WriteLine();
MinString(resultArray);