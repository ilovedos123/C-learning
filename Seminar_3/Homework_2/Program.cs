// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите x первой точки:", " ");
double x1 = int.Parse(Console.ReadLine());
Console.Write("Введите y первой точки:", " ");
double y1 = int.Parse(Console.ReadLine());
Console.Write("Введите z первой точки:", " ");
double z1 = int.Parse(Console.ReadLine());
Console.Write("Введите x второй точки:", " ");
double x2 = int.Parse(Console.ReadLine());
Console.Write("Введите y второй точки:", " ");
double y2 = int.Parse(Console.ReadLine());
Console.Write("Введите z второй точки:", " ");
double z2 = int.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
Console.Write($"{result:f2}");