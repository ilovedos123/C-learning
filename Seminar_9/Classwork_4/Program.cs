// Напишите программу, которая на вход принимает 2 числа А и В, и возводит число А в целую степень В.
//А=3; B=5 -> 243
//A=2; B=3 -> 8

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int Multi(int m, int n)
{
if (n < 1) 
{
return 1;
}
return m*Multi(m,n-1);
}
Console.Write(Multi(m, n));

//int DegreeOfNumber(int numberA, int numberB)
//{
//if (numberB < 1) return 1;
//return numberA * (DegreeOfNumber(numberA, numberB - 1));
//}