// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultipleArray(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int x = 0; x < array1.GetLength(1); x++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                resultArray[i, x] += array1[i, j] * array2[j, x];
            }

        }
    }
    return resultArray;
}


int m1 = Promt("Введите число строк и столбцов массивов ");

if (m1 <= 1) 
{
    System.Console.WriteLine("Число не должно быть меньше или равно 1");
    Environment.Exit(1);
}

int n1 = m1;
int[,] myArray1 = CreateArray(m1, n1);
System.Console.WriteLine("Первый массив:");
PrintArray(myArray1);

System.Console.WriteLine();

int m2 = m1;
int n2 = m1;
int[,] myArray2 = CreateArray(m2, n2);
System.Console.WriteLine("Второй массив:");
PrintArray(myArray2);

int[,] resutArr = MultipleArray(myArray1, myArray2);

System.Console.WriteLine("Произведение первого массива на второй:");
PrintArray(resutArr);