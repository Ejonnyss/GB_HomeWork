// Задача 47: Задайте двумерный массив размером 
// m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Решение: 

void FillArray (double [,] twoArray)
{
    for (int i = 0; i < twoArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoArray.GetLength(1); j++)
        {
            twoArray[i,j] = 10 + new Random().NextDouble() * (-10-10);
            twoArray[i,j] = Math.Round((twoArray[i,j]),2);
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

double [,] array = new double [5,5];
FillArray(array);
PrintArray(array);