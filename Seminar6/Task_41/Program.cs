// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int [] CreateArray ()
{ 
    Console.WriteLine("Введите количество чисел (M): ");

    int sizeM = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[sizeM];
    for (int i = 0; i < sizeM; i++)
    {
        Console.WriteLine($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PositiveCount (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count = count+1;
    }
    Console.WriteLine ($"Количество положительных чисел: {count}");
}

// Console.WriteLine ("Получившийся массив: ");
// ShowArray(array);

int [] array = CreateArray();
PositiveCount(array);