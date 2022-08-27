//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows, cols, 1, 10);
PrintArray(arr);
Console.Write("Введите номер столбца для расчета среднего арифметического: ");
int c = int.Parse(Console.ReadLine());

GetColumnAverage(arr, c);

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
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void GetColumnAverage(int[,] array, int column)
{
     double result;
     double product = 0;
     if (column < 0 || column > array.GetLength(1) - 1)
     {
        Console.Write($"Такого столбца в данном массиве не существует");
     }
     else
        {
        for (int j = 0; j < (array.GetLength(0)); j++)
        {
            product = product + array[j, column];           
        }
     result = product/array.GetLength(0);
Console.Write($"Среднее арифметическое элементов заданного столбца равно {result:F1}");
    Console.WriteLine();
    }
}