// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

string NaturalNumbers(int m, int n)
{
    if ( n < m)
    {
        return $" ";
    }
return  NaturalNumbers(m, n-1) + $" {n}";
}
Console.WriteLine(NaturalNumbers(m, n));