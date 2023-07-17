// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//            значения b1, k1, b2 и k2 задаются пользователем.
//            b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите целове число b1");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите целове число k1");
int k1 = int.Parse(Console.ReadLine()!); ;
Console.WriteLine("Введите целове число b2");
int b2 = int.Parse(Console.ReadLine()!); ;
Console.WriteLine("Введите целове число k2");
int k2 = int.Parse(Console.ReadLine()!); ;

void PointOfCrossLines(int b1, int k1, int b2, int k2)
{
    double x = 0;
    double y = 0;
    if (k1 - k2 != 0)
    {
        if(k1-k2<0)
        {
        x = (b2 - b1)/Math.Abs(k1 - k2);
        }
        else x = (b2 - b1) / (k1 - k2);
    }
    else Console.WriteLine("k1=k2, происходит деление на ноль");
    y = k1 * x + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1},  b2 = {b2}, k2 = {k2}, => ({x} , {y})");
}
PointOfCrossLines(b1, k1, b2, k2);
