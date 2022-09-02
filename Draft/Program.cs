//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07



int[,] arr = GetArray(8, 8);
PrintArray(arr);

int[,] GetArray(int m, int n)
{
    int count = 10;
    int[,] array = new int[m, n];
   // while (count <= array.GetLength(0)*array.GetLength(1))
  // {
       // int zero = 0;
       //int one = 1;
       //int two = 2;
        for (int i = 0; i < array.GetLength(1); i++)             //направо
        {
            array [0,i] = count;
            count++;        
        }        
        for (int j = 1; j < array.GetLength(0); j++)             //вниз 
        {
            array [j,array.GetLength(0)-1] = count;
            count++;
        }
        for (int k = array.GetLength(1)-2; k >= 0; k--)          //влево
        {
            array [array.GetLength(0)-1, k] = count;
            count ++;                   
        }
        for (int l = array.GetLength(0)-2; l >= 1; l--)          //вверх
            {
                array [l,0] = count;
                count ++;
            }
       //zero++;
       //начали новый оборот
        for (int o = 1; o < array.GetLength(1)-1; o++ )           //направо
        {
         array[1,o]= count;
         count++;
        } 
         for (int p = 2; p < array.GetLength(0)-1; p++ )         //вниз
        {
            array[p,array.GetLength(0)-2] = count;
            count++;
        }   
        for (int q = array.GetLength(1)-3; q >= 1; q--)          //влево
        {
            array[array.GetLength(0)-2,q] = count;
            count++;
        }
        for (int r = array.GetLength(0)-3; r >= 2; r--)          //вверх
        {
                array [r,1] = count;
                count ++;
            }
       for (int s = 2; s < array.GetLength(1)-2; s++ )           //направо
        {
         array[2,s]= count;
         count++;
        } 
        for (int t = 3;t < array.GetLength(0)-2; t++ )           //вниз
        {
            array[t, array.GetLength(0)-3 ] = count;
            count++;
        }
        for (int u = array.GetLength(1)-4; u >= 2; u--)          //влево
        {
            array[array.GetLength(0)-3,u] = count;
            count++;
        }
        for (int v = array.GetLength(0)-4; v >= 3; v--)          //вверх
        {
                array [v,2] = count;
                count ++;
            }

   //}

    
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
