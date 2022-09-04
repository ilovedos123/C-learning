// Задача 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные число в промежутке от M до N.
//M =1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N =8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());

void PrintNumber(int m, int n)
{
if (n < m) return;
PrintNumber(m, n - 1);
Console.Write(n + ",");
}
PrintNumber(m, n);