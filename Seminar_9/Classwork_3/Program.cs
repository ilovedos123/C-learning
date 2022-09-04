// Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

int SumOfNumbers (int n)
{
    if(n < 1)
    {
        return 0; 
        
    }
    return SumOfNumbers (n/10) + n%10;
    
    
}
Console.Write(SumOfNumbers (234));