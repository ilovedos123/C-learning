//Не использую рекурсию, выведите N чисел Фибоначчи.
//Если N = 5-> 0 1 1 2 3
//Если N = 3-> 0 1 1 
//Если N = 7> 0 1 1 2 3 5 8 

Console.Write("Введите число :", " ");
int number = int.Parse(Console.ReadLine());
int[] array = new int [number];
int result = 0;
array[0] = 0;
array[1] = 1;
for (int i = 2; i < number; i++)
{
    result = array[i - 2] + array[i - 1];
    array[i] = result;
}
Console.WriteLine($"[{string.Join(",",array)}]");