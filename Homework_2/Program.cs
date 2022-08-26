Console.Write("Введите число 1:", " ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2:", " ");
int number_2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3:", " ");
int number_3 = int.Parse(Console.ReadLine());
int maximum = number_1;
if (number_1 > number_2)
{
    maximum = number_1;
}
else
{
    maximum = number_2;
}
if (number_3 > maximum)
{
   maximum = number_3;
    Console.Write($"Максимальное число {maximum}");
}
else
{
  Console.Write($"Максимальное число {maximum}");  
}