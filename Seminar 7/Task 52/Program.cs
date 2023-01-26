// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray (double [,] twoArray)
{
    for (int i = 0; i < twoArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoArray.GetLength(1); j++)
        {
            twoArray[i,j] = 10 + new Random().NextDouble() * (0-10);
            twoArray[i,j] = Math.Round((twoArray[i,j]),0);
        }
    }
} 

void PrintArray (double [,] twoArray)
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

double [,] array = new double [3,4];
FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца: ");

double average = 0;

for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        average += array[i,j];
    }
    Console.Write(Math.Round((average/array.GetLength(0)),1) + "; ");
    average = 0;
}