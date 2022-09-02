// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
Console.Write("Введите количество строк первой матрицы: ");
int rowsFirst = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int colsFirst = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int rowsSecond = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int colsSecond = int.Parse(Console.ReadLine());
if (colsFirst != rowsSecond)
{
    Console.Write(" Произведение введенных матриц невозможно найти");
}
else
{
int[,] firstMatrix = GetArray(rowsFirst, colsFirst, 1, 10);
int[,] secondMatrix = GetArray(rowsSecond, colsSecond, 1, 10);
PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
PrintArray(GetMatrixMultiply(firstMatrix, secondMatrix));

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

int[,] GetMatrixMultiply(int[,] matrix_1, int[,] matrix_2)
{
    int [,] result = new int [matrix_1.GetLength(0), matrix_2.GetLength(1)];
        for (int i = 0; i < matrix_1.GetLength(0); i++)
    {
        for (int j = 0; j <matrix_2.GetLength(1); j++)
        {
             for (int k = 0; k < matrix_2.GetLength(0); k++)
        {
               result[i,j] += matrix_1[i,k] * matrix_2[k,j];             
        }
                 
        }
        
    }
   return result;
}
}