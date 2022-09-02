// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());
if (rows == cols)
{
   Console.Write("Массив не прямоугольный"); 
}
else
{int[,] arr = GetArray(rows, cols, 1, 10);
PrintArray(arr);
Console.WriteLine();
GetSmallestString(arr);
}

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
void GetSmallestString(int[,] array)
{
    int [] result = new int [array.GetLength(0)];
    int sum = 0;
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
         sum = sum + array[i,j];         
        }
        result [i] = sum;
        sum = 0;
    }
   int min = result[0];
   int valve = 0;
   for (int k = 0; k < result.Length; k++)
   {
    if (result[k] < min)
    {
        min = result[k];
        valve = k;
            }
   }
   Console.WriteLine($"Номер строки с наименьшей суммой элементов: {valve}"); 
}