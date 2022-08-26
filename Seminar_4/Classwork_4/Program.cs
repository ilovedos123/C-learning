// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1, 0, 1, 1, 0, 1, 0, 0]

int [] RandomNumber(int size)
{
    int count = 0;
    int[] arr = new int[size];
        while (count < size)
    {
        int i = new Random().Next(2);
        arr[count] = i;
        count = count + 1;
        
    }
return arr;
}

int [] array = RandomNumber(8);

for (int i = 0; i < array.Length; i++ )
{
Console.Write(array[i]);
}