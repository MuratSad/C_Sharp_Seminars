// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек X,Y,Z");
Console.WriteLine("Введите x1=");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y1=");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z1=");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите x2=");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y2=");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z2=");
int z2 = int.Parse(Console.ReadLine()!);
double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
Console.WriteLine($"Расстояние между двумя точками = " + result);
