

int result;
     int product = 1;
     if (column <0 || column > array.GetLength(0) - 1)
     {
        Console.Write($"Такого столбца в данном массиве не существует");
     }
     else
        {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            product = product * array[j, column];
        }
     result = product/array.GetLength(1) - 1;
Console.Write($"Среднее арифметическое элементов заданного столбца равно {result}");
     }