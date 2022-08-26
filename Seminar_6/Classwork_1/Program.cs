// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы, двух других сторон.

Console.Write("Введите число 1:", " ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2:", " ");
int number_2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3:", " ");
int number_3 = int.Parse(Console.ReadLine());
if ( number_1 < number_2 + number_3 && number_2 < number_1 + number_3 && number_3 < number_1 + number_2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}