Console.Write("Введите число 1:", " ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2:", " ");
int number_2 = int.Parse(Console.ReadLine());

if (number_1 == number_2)
{
    Console.Write($"Числа равны");
}
else
{  
    if (number_1 > number_2)
    {
    Console.Write($"Большее число {number_1}, Меньшее число {number_2}");
    }
    else
    {
       Console.Write($"Большее число {number_2}, Меньшее число {number_1}"); 
    }
}
