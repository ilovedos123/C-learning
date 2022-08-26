// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
Console.Write("Введите четверть:", " ");
int quarter = int.Parse(Console.ReadLine());
switch(quarter)
{
    case 1:
    {
        Console.Write("y больше ноля, x больше ноля");
        break;
    }
    case 2:
    {
       Console.Write("y больше ноля, x меньше ноля");
       break; 
    }
    case 3:
    {
        Console.Write("y меньше ноля, x меньше ноля");
        break;
    }
    case 4:
    {
       Console.Write("y меньше ноля, x больше ноля");
       break; 
    }
    default:
    {
       Console.Write("Введите число от 1 до 4"); 
       break;
    }
}