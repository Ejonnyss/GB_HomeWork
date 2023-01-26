// Задача 50: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

int m = 3;
int n = 4;
int [,] array = new int [m,n];
FillArray(array);
PrintArray(array);
Console.WriteLine();

 // Поиск элемента массива по его позиции: 
Console.WriteLine("Укажите номер строки: ");
int searchI = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Укажите номер столбца: ");
int searchJ = Convert.ToInt32(Console.ReadLine()) - 1;

if (searchI < m && searchJ < n) Console.WriteLine($"Искомый элемент: {array [searchI,searchJ]}");
else Console.WriteLine("Такого элемента в массиве нет");

 // Поиск числа в массиве: 
Console.WriteLine();
Console.Write("Укажите число которое необходимо найти: ");
int searchX = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == searchX) 
            {
                Console.WriteLine($"Расположение элемента: строка {i+1} столбец {j+1}");
                count++;
            }
        }
    }
if (count == 0) Console.WriteLine("Число не найдено");