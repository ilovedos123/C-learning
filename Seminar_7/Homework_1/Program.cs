// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
double[,] array = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();     
    }
   }
   return array;
}
double[,] arr = GetArray(rows, cols, -10, 10);

void PrintArray(double[,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j <array.GetLength(1); j++)
        {
            Console.Write("{0,6:F1}", array[i, j]);
        }
        Console.WriteLine();
    }
}
PrintArray(arr);
