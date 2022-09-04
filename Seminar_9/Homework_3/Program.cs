// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int FindAkkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n > 0) && (m == 0))
      return FindAkkerman(n - 1, 1);
    else
      return FindAkkerman(n - 1, FindAkkerman(n, m - 1));
}
Console.WriteLine(FindAkkerman(n, m));