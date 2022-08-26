int[] collection = {6, 2, 8, 13, 45, 4};

void SelectionSort(int[] array)
{
    
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        Console.Write($"{minPosition} ");
        Console.Write($"{i} ");
        for (int j= i + 1; j< array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
    int temp = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temp;
    }
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
}

PrintArray(collection);
Console.WriteLine("");
SelectionSort(collection);
Console.WriteLine("");
PrintArray(collection);