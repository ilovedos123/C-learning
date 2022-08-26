// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");
string num  = Console.ReadLine();

int GetNumberOfPositive (string numbers)
{
int[] array = numbers.Split(',').Select(int.Parse).ToArray();
Console.WriteLine($"[{string.Join(",",array)}]");
int count = 0;
for (int i = 0; i<array.Length; i++)
{
    if (array[i] > 0)
    {
        count ++;
    }
}
return count;
}

Console.Write($"{GetNumberOfPositive(num)} чисел больше нуля");