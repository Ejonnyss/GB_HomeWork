// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

void FillArray(int[,,] threeArray)
{
    for (int i = 0; i < threeArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeArray.GetLength(1); j++)
        {
            int k = 0;
            while (k < threeArray.GetLength(2))
            {
                int number = new Random().Next(10, 100);
                if (CheckNumber(threeArray, number)) continue;
                threeArray[i, j, k] = number;
                k++;
            }

        }
    }
    bool CheckNumber(int[,,] threeArray, int num)
    {
        for (int i = 0; i < threeArray.GetLength(0); i++)
        {
            for (int j = 0; j < threeArray.GetLength(1); j++)
            {
                for (int k = 0; k < threeArray.GetLength(2); k++)
                {
                    if (threeArray[i, j, k] == num) return true;
                }
            }
        }
        return false;
    }
}

void PrintArray(int[,,] threeArray)
{
    for (int i = 0; i < threeArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeArray.GetLength(2); k++)
            {
                Console.Write($"{threeArray[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix = new int[2, 2, 2];
FillArray(matrix);
PrintArray(matrix);
