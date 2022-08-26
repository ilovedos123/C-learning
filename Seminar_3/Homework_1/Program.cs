// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число :", " ");
int number = int.Parse(Console.ReadLine());
int second_number;
int fourth_number;
int first_number;
int last_number;
if (number < 0)
{
    number = -number;
}
if (number >= 100000 || number < 10000)
{
    Console.Write("Число не пятизначное"); 
}
else
{
second_number = (number/1000) % 10;
fourth_number = (number/10) % 10;
first_number = (number/10000);
last_number = (number % 10);
if (first_number == last_number && second_number == fourth_number)
{
    Console.Write($"Число {number} является палиндромом");
} 
else
{
    Console.Write($"Число {number} не является палиндромом");
}
}