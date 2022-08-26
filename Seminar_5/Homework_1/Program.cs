// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая 
//покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());

int[] GetArrayThreeNumbers(int size)
{
    int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 999);
}
return array;
}
int[] array = GetArrayThreeNumbers(length);

Console.WriteLine($"[{string.Join(",",array)}]");

void GetEvenNumber(int[] massive)
{
int result = 0;
for (int j = 0; j < massive.Length; j++)
{
    if (massive[j] % 2 == 0)
    {
       result = result + 1;
    }
}
Console.Write($"Количество четных чисел в массиве равно {result}");
}
GetEvenNumber(array);
