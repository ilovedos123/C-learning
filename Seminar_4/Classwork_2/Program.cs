Console.Write("Введите число:", " ");
int number = int.Parse(Console.ReadLine());
int count = 0;
while (number > 0)
{
    number = number / 10;
    count = count + 1;
}
Console.WriteLine(count);
