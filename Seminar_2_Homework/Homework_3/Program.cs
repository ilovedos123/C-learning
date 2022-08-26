//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7 :", " ");
int number = int.Parse(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.Write($"Недопустимое число");
}
else
{
if(number >=1 && number <6)
{
    Console.Write("Этот день не выходной");
}
else
{
    Console.Write("Этот день выходной");
}
}