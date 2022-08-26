// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int array_size = 8;

int [] RandomArray(int size)
{
int [] array = new int [size];
for (int i = 0; i < size; i++)
{
   int number = new Random().Next(100);
   array[i] = number; 
}
return array;
}

int [] print_array = RandomArray (array_size);
Console.WriteLine($"[{string.Join(", ", print_array)}]");