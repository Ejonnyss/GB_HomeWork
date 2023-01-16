// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

Console.WriteLine("Введите желаемый размер массива:");
int N = int.Parse(Console.ReadLine());

int [] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(N, 100, 999);
int count = 0;

    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i]%2 == 0) count++;
    }
Console.WriteLine("Полученыый массив:");
ShowArray(myArray);
Console.WriteLine($"Количество четных чисел в массиве: {count}");