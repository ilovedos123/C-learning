Console.Write("Введите число:", " ");
int number = int.Parse(Console.ReadLine());
int count = 0;
if (number>=2)
{
    while (count<(number-1))
    {
        count = count + 2;
        Console.Write($"{count} ");
    }
}
else
{
    Console.Write($"Неправильное условие");
}