// 1. Формирование массива случайных чисел и вывод на экран.
Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());

int[] GetArrayNumbers(int size)
{
    int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 999);
}
return array;
}

int[] array = GetArrayNumbers(length);

Console.WriteLine($"[{string.Join(",",array)}]");

//2. Замена местами парных элементов массива.
void ReverseArray(int[] inArray)
{
    for(int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}
int [] array = new int[]{55, 88, 93, 44};
Console.WriteLine($"[{string.Join(",",array)}]");
ReverseArray(array);
Console.WriteLine($"[{string.Join(",",array)}]");

//3. Ввод 3х чисел.
Console.Write("Введите число 1:", " ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2:", " ");
int number_2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3:", " ");
int number_3 = int.Parse(Console.ReadLine());

//4. Перевод строки, состоящей из чисел в массив, состоящий из этих чисел.
Console.Write("Введите числа через запятую: ");
string numbers  = Console.ReadLine();

int[] array = numbers.Split(',').Select(int.Parse).ToArray();
Console.WriteLine($"[{string.Join(",",array)}]");