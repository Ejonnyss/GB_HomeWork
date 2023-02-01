// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int [,] matrix = new int [3,4];
FillArray(matrix);
Console.WriteLine("Исходный массив:");
PrintArray(matrix);
Console.WriteLine();

int minSum = 0;
int sumLine = SumLineElements(matrix, 0);

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSum = i;
  }
}

Console.WriteLine($"Строка с наименьшей суммой элементов ({sumLine}): {minSum+1} строка");


