//Задайте двумерный массив.Напишите программу, которая поменяет местами первую и последнюю строку.
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows, cols, 10, 99);
PrintArray(arr);
Console.WriteLine();
ChangeArrayStrings(arr);
PrintArray(arr);

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

int[,] ChangeArrayStrings(int[,] array)
{
    int change;
 
       for (int i = 0; i <array.GetLength(1); i++)
        {
        change = array[0, i];
        array[0, i] = array[(array.GetLength(0)-1), i ];
        array[(array.GetLength(0)-1), i] = change; 
        }
             return array;
}