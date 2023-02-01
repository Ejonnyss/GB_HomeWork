// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

void FillArray(int[,] twoArray)
{
    for (int i = 0; i < twoArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoArray.GetLength(1); j++)
        {
            twoArray[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] twoArray)
{
    for (int i = 0; i < twoArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoArray.GetLength(1); j++)
        {
            Console.Write($"{twoArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ProductMatrix(int[,] firstMat, int[,] secondMat)
{
    int[,] resultMat = new int[firstMat.GetLength(0), secondMat.GetLength(1)];
    if (firstMat.GetLength(1) != secondMat.GetLength(0))
    {
        Console.WriteLine("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }
    else
    {
        for (int i = 0; i < resultMat.GetLength(0); i++)
        {
            for (int j = 0; j < resultMat.GetLength(1); j++)
            {
                int sum = 0;
                for (var k = 0; k < firstMat.GetLength(1); k++)
                {
                    sum += firstMat[i, k] * secondMat[k, j];
                }
                resultMat[i, j] = sum;
            }
        }
        Console.WriteLine("Результирующая матрица: ");
        PrintArray(resultMat);
    }
}

int[,] firstMatrix = new int[3, 4];
FillArray(firstMatrix);
int[,] secondMatrix = new int[4, 3];
FillArray(secondMatrix);

PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
Console.WriteLine();

ProductMatrix(firstMatrix, secondMatrix);