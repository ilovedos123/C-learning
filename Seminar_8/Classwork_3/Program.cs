int[] arr = new int[14] {1, 9, 9, 0, 2, 8, 0, 9, 15, 15, 42, 15, 42, 15};
    int rev;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] < arr[j])
        {
            rev = arr[i];
            arr[i] = arr[j];
            arr[j] = rev;
        }
    }
}
Console.WriteLine($"[{string.Join(",",arr)}]");
    
    
    
    int count = 1;
    for ( int i = 0; i < arr.Length-1; i++)
    {
        if (arr[i] == arr[i+1])
        {
            count ++;
        }
        else
        {
            Console.WriteLine($"{arr[i]} встречается {count} раз");
            count = 1;
        }
    }

Console.WriteLine($"{arr[arr.Length-1]} встречается {count} раз");