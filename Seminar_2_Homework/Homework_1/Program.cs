Console.Write("Введите трехзначное число :", " ");
int number = int.Parse(Console.ReadLine());
if (number/100 < 1 || number/100 >= 10)
{
    Console.Write($"Число не трехзначное");
}
else
{
    int result = (number % 100)/10; 
    Console.Write(result);
}