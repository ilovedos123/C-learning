//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5->1,4,9,16,25
//2->1,4
Console.Write("Введите число :", " ");
int number = int.Parse(Console.ReadLine());
int count = 1;
if (number<0)
{
    number = number*-1;
}
while (count <= number)
{
    Console.WriteLine(Math.Pow(count, 2));
    count ++;
}