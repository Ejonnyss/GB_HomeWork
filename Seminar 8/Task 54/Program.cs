// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

void FillArray (int [,] twoArray)
{
    for (int i = 0; i < twoArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoArray.GetLength(1); j++)
        {
            twoArray[i,j] = new Random().Next(1,10);
        }
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

void Sorting (int [,] twoArray)
{
     for (int i = 0; i < twoArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoArray.GetLength(1); j++)
        {
            for (int k = 0; k < twoArray.GetLength(1)-1; k++)
            {
                if (twoArray[i, k] < twoArray[i, k + 1])
                {
                    int temp = twoArray[i, k + 1];
                    twoArray[i, k + 1] = twoArray[i, k];
                    twoArray[i, k] = temp;
                }
            }
            
        }
    }
}


int [,] matrix = new int [3,4];
FillArray(matrix);
Console.WriteLine("Исходный массив:");
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
Sorting (matrix);
PrintArray(matrix);