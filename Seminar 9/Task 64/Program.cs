// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

void NaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        NaturalNumbers(m + 1, n);
        Console.Write($"{m} ");
    }
}
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;

Console.Write($"N = {n} -> ");
NaturalNumbers(m, n);