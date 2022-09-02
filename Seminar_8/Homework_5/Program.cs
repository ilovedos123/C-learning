//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
int[,] arr = GetSpiralArray(10, 10);
PrintArray(arr);

int[,] GetSpiralArray(int m, int n)
{
    int count = 1;
    int[,] array = new int[m, n];
    int zero = 0;
    int one = 1;
    int two = 2;
    while (count <= array.GetLength(0)*array.GetLength(1))
    {
         for (int i = zero; i < array.GetLength(1)-zero; i++)             //направо
        {
            array [zero,i] = count;
            count++;        
        }        
        for (int j = one; j < array.GetLength(0)-zero; j++)             //вниз 
        {
            array [j,array.GetLength(0)-one] = count;
            count++;
        }
        for (int k = array.GetLength(1)-two; k >= zero; k--)          //влево
        {
            array [array.GetLength(0)-one, k] = count;
            count ++;                   
        }
        for (int l = array.GetLength(0)-two; l >= one; l--)          //вверх
            {
                array [l,zero] = count;
                count ++;
            }
       zero++;
       one++;
       two++;
   }
return array;      
}
     
void PrintArray(int[,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
