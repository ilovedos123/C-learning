// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());

int[] GetArrayThreeNumbers(int size)
{
    int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-99, 99);
}
return array;
}
int[] array = GetArrayThreeNumbers(length);

Console.WriteLine($"[{string.Join(",",array)}]");

void GetOddNumberSum(int[] massive) 
{
int count = 0;
int result = 0;
while (count < massive.Length)
{
    if (count % 2 != 0)
    {
        result = result + massive[count];
        count = count +1;
    }
    else
    {
        count = count + 1;
    }
}
Console.Write($"Сумма элементов массива, стоящих на нечетных позициях равно {result}");
}
GetOddNumberSum(array);
