// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

Console.WriteLine("Введите желаемый размер массива:");
int N = int.Parse(Console.ReadLine());

double [] CreateRandomArray(int N, int start, int end)
{
    double[] RandomArray = new double[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = end + new Random().NextDouble() * (start - end);
        RandomArray[i] = Math.Round((RandomArray[i]),2);
    }
    return RandomArray;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double [] myArray = CreateRandomArray(N, -100, 100);
double min = myArray[0];
double max = myArray[0];

    for (int i = 0; i < myArray.Length; i++)
    {
       if (max < myArray[i]) max = myArray[i];
       if (min > myArray[i]) min = myArray[i];
    }
double diff = max - min;

Console.WriteLine("Полученыый массив вещественных чисел:");
ShowArray(myArray);
// Console.WriteLine($"Минимальное значение: {min}, максимальное значение: {max}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diff}");