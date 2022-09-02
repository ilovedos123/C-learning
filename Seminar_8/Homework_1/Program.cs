﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows, cols, 1, 10);
PrintArray(arr);
SortArray(arr);
Console.WriteLine();
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
Console.WriteLine();

int[,] SortArray(int[,] array)
{
    int rev;
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
        {
            if (array[i, j] < array[i,k])
            {
                rev = array[i, j];
                array[i, j] = array[i,k];
                array[i,k] = rev;                             
            }
        }
        }
    }
    return array;
}