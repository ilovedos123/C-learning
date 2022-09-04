// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int SumOfElements(int m, int n)
{
    if ( n <= m)
    {
    return m;
    }
return n + SumOfElements(m, n-1);
}
Console.WriteLine(SumOfElements(m, n));

