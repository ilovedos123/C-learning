// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число :", " ");
int num = int.Parse(Console.ReadLine());

int FindSumm(int number)
{
int result = 0;
if (number < 0)
{
    number = -number;
}
while (number > 0)
{
    result = result + number % 10;
    number = number/10;
      
}
return(result);
}

int sum = FindSumm(num);
Console.Write(sum);
