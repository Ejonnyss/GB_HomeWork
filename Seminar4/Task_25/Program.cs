// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную 
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int X = A;

for(int i = 1; i < B; i++)
{
   X = X * A;
}
Console.Write($"Число {A} в степени {B} равно:{X}");

// Console.WriteLine($"Число {A} в степени {B} равно: {Math. Pow(A, B)}");

