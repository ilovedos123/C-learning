// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Write("Введите число :", " ");
int number = int.Parse(Console.ReadLine());
int count = 1;
if (number > 0)
{
while (count <= number)
{
    Console.WriteLine(Math.Pow(count, 3));
    count ++;
}
}
else if (number == 0)
{
    Console.WriteLine($"Введите другое число");
}
else if (number < 0)
{
    while (count >= number)
    {
        Console.WriteLine(Math.Pow(count, 3));
    count = count - 1;
    }
}