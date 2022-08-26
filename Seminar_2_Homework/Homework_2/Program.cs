//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число :", " ");
int number = int.Parse(Console.ReadLine());
if (number < 100 && number > -100)
{
    Console.Write($"Третьей цифры нет");
}
else
{
    if (number > 0)
    {
    while (number >= 1000)
    {
        number = number / 10;        
    }
    int third_number = number % 10;
    Console.Write(third_number);
    }
    else if (number < 0)
    {
    while (number <= -1000)
    {
        number = number / 10;        
    }
    int third_number = number % 10;
    Console.Write(third_number);
    }
}

