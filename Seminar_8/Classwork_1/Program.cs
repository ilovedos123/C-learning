//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В с лучае если это невозможно, программа должна вывести
//сообщение для пользователя.
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows, cols, 10, 99);
PrintArray(arr);
Console.WriteLine();

int[,] arr2 = ReverseRowsCols(arr);
PrintArray(arr2);

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
int[,] ReverseRowsCols(int[,] array)
{
  int[,] result = new int[array.GetLength(0),array.GetLength(1) ];
  for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            result[j, i] = array[i, j];
           
        }
        
    }
   return result; 
}
        
