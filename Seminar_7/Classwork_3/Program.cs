//Задайте двумерный массив. Найдите элементы у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Изначально массив выглядел так:                     А будет выглядеть так:
//1 4 7 2                                                 1 4 49 2
//5 9 2 3                                                 5 9 2 9
//8 4 2 4                                                 64 4 4 4
int m = 4;
int n = 4;

int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j <n; j++)
        {
            array[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
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

for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array [i, j] = array [i,j] * array [i,j];
            }
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
