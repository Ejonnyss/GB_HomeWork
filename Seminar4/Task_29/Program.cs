// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

Console.WriteLine("Введите желаемый размер массива:");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

Console.WriteLine("Заполнить массив вручную (0) или автоматически (1)?");
int choice = int.Parse(Console.ReadLine());

if (choice == 0)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
else 
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}
Console.WriteLine("Полученный массив: ");

for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }