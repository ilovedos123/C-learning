// Напишите прграмму, которая принимает на вход число N и выдает произведение чисел от 1 ло N.
//4 -> 24
//5 -> 120

Console.Write("Введите число :", " ");
int number = int.Parse(Console.ReadLine());
int FindMult(int num)
{
int result = 1;
int count = 1;
while (count <= number )
{
    result = result * count;
    count = count + 1;
}
return result;
}
Console.Write(FindMult(number));