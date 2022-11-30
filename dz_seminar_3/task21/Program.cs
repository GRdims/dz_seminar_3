// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine ("Введите координату x первой точки: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату y первой точки: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату x второй точки: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату y второй точки: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату y первой точки: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату x второй точки: ");
int zb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату y второй точки: ");

double result = Math.Sqrt (Math.Pow((xb-xa), 2) + Math.Pow((yb-ya),2) + + Math.Pow((zb-za),2));

Console.WriteLine($"Расстояние между точками в 3D пространстве равно: {result:f2}");


