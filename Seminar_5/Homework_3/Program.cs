// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());

double[] GetArrayNumbers(int size)
{
    double[] array = new double[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-99, 99);
}
return array;
}
double[] array = GetArrayNumbers(length);
Console.WriteLine($"[{string.Join(",",array)}]");

double FindMax(double[] massive)
{
    double max = 0;
    for (int j = 0; j < massive.Length; j++)
    {
        if (massive[j] > max)
        {
            max = massive[j];
        }
    }
    return max;
}

double FindMin(double[] massive)
{
    double min = 0;
    for (int k = 0; k < massive.Length; k++)
    {
        if (massive[k] < min)
        {
            min = massive[k];
        }
    }
    return min;
}

double diff = FindMax(array) - FindMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {diff}");

