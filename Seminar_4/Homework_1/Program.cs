// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число 1:", " ");
int num_1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2:", " ");
int num_2 = int.Parse(Console.ReadLine());

GetExp(num_1, num_2);

void GetExp( int number_1, int number_2)
{
int result = number_1;
if (number_2 < 0)
{
    Console.Write("Второе число должно быть положительным");
}
else if (number_2 == 0)
{
    result = 1;
    Console.Write(result);
}
else
{
for (int count =1; count < number_2; count ++)
{
    result = result * number_1;
}
Console.Write(result);
}
}