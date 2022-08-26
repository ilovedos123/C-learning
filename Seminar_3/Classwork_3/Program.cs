// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2d пространстве.
//A(3,6);B(2,1)-> 5,09
//A(7,-5);B(1,-1)->7,21
Console.Write("Введите x первой точки:", " ");
double x1 = int.Parse(Console.ReadLine());
Console.Write("Введите y первой точки:", " ");
double y1 = int.Parse(Console.ReadLine());
Console.Write("Введите x второй точки:", " ");
double x2 = int.Parse(Console.ReadLine());
Console.Write("Введите y второй точки:", " ");
double y2 = int.Parse(Console.ReadLine());
double a = x2 - x1;
double b = y2 - y1;
double square_a = a*a;
double square_b = b*b;
double c = Math.Sqrt(square_a + square_b);
 Console.Write(c);

