Console.Write("Введите число 1:", " ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите число 2:", " ");
int y = int.Parse(Console.ReadLine());
if (x == 0 || y == 0)
{
   Console.Write($"Одно или оба числа не могут быть равным нулю"); 
}
else if (y > 0 && x > 0)
{
    Console.Write($"Первая четверть");
}
else if (y > 0 && x < 0)
{
    Console.Write($"Вторая четверть");
}
else if (y < 0 && x < 0)
{
    Console.Write($"Третья четверть");
}
else if (y < 0 && x > 0)
{
    Console.Write($"Четвёртая четверть");
}