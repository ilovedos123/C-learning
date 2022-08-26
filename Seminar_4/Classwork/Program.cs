// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел из которых он составлен.
// 47 -> 11
// 6541 -> 16
// 89 - > 17
Console.Write("Введите число:", " ");
int num = int.Parse(Console.ReadLine());
int GetSum(int number)
{int first_number = number;
int plus;
int result = 0;
int final_result;
while (first_number > 10)
{
    first_number = first_number/10;
    
}
while (number > 10)
{
    plus = (number % 10);    
    number = number / 10;
    result = result + plus;    
}
final_result = result + first_number;
return final_result;
}

Console.Write(GetSum(num));





//int getResult(int number)
//{
//    int result = 0;
//    int count= 0;
//    while (count > 0)
//    {
//        count = (number / 10) % 10;
//        result = result + count;
//    }
//}