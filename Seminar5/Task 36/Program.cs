// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] myArray = CreateRandomArray(N, -100, 100);
int sum = 0;

    for (int i = 0; i < myArray.Length; i++)
    {
       if (i % 2 != 0) sum = sum + myArray[i];
    }
Console.WriteLine("Полученыый массив:");
ShowArray(myArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");