// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

void SpiralFillArray(int[,] twoArray)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= twoArray.GetLength(0) * twoArray.GetLength(1))
    {
        twoArray[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < twoArray.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= twoArray.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > twoArray.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

void PrintArray (int [,] twoArray)
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

int[,] matrix = new int[4, 4];
SpiralFillArray(matrix);
PrintArray(matrix);

