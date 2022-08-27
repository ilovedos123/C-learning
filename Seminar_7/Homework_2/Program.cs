// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//17 -> такого числа в массиве нет

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows, cols, 1, 10);
PrintArray(arr);

Console.Write("Введите строку элемента массива: ");
int r = int.Parse(Console.ReadLine());
Console.Write("Введите столбец элемента массива: ");
int c = int.Parse(Console.ReadLine());

FindElement(arr, r, c);
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j <n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }        
    }
    return array;
}
void PrintArray(int[,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] array, int row, int col)
{
    if (row < 0 || row > array.GetLength(0) - 1 || col < 0 || col > array.GetLength(1) - 1 )
    {
        Console.WriteLine($"Такого элемента в массиве нет");
    }
    else
    {
      Console.WriteLine($"Элемент на введенных позициях - {array[row, col]}");
    }
}
