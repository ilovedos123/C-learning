// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// Например задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Сумма элементов 1+9+2=12

int m = 3;
int n = 4;

int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j <n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
int result = 0;
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + array[i, j];
            }
        }
    }
    Console.WriteLine(result);

