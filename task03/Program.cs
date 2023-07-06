/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18
*/

Console.Write("Введите количество строк в матрице 1: ");
int rowsMatrix1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в матрице 1: ");
int columnsMatrix1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество строк в матрице 2 должно быть равно количеству столбцов матрицы 1.");
int rowsMatrix2 = columnsMatrix1;
Console.Write("Введите количество столбцов в матрице 2: ");
int columnsMatrix2 = int.Parse(Console.ReadLine()!);

int[,] matrix1 = GetMatrix(rowsMatrix1, columnsMatrix1, 1, 10);
PrintArray(matrix1);
Console.WriteLine();
int[,] matrix2 = GetMatrix(rowsMatrix2, columnsMatrix2, 1, 10);
PrintArray(matrix2);
int[,] multMatrix = new int[rowsMatrix1, columnsMatrix2];

Console.WriteLine();
Console.WriteLine("Результирующая матрица будет: ");

PrintArray(GetMultMatrix(matrix1, matrix2, multMatrix));

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    return result;
}

int[,] GetMultMatrix(int[,] matrix1, int[,] matrix2, int[,] multMatrix)
{
    for (int i = 0; i < multMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            multMatrix[i, j] = sum;
        }
    }
    return multMatrix;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

