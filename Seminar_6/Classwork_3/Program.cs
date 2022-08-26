//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 999);
}
int[] massive = new int[size];
for (int j = 0; j < size; j++)
{
    massive[j]= array[j];
}

Console.WriteLine($"[{string.Join(",",array)}]");
Console.WriteLine($"[{string.Join(",",massive)}]");