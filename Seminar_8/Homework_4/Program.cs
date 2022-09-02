﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
int[,,] arr = GetArray(2, 2, 2);
PrintArray(arr);

int[,,] GetArray(int m, int n, int o)
{
    int count = 10;
    int[,,] array = new int[m, n, o];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j <n; j++)
        {
            for (int k = 0; k < o; k++)
            {
                
                array[i, j, k] = count;
                count++;
            }
        }        
    }
    return array;
}
void PrintArray(int[,,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
          for (int k = 0; k <array.GetLength(2); k++)
        {
            Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
        }  
        }
        Console.WriteLine();
    }
}