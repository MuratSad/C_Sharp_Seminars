// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

Console.WriteLine("Введите число a = ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b = ");
int B = int.Parse(Console.ReadLine()!);

if (A>B)
{
Console.Write("a = ");
Console.WriteLine(A);
Console.Write("b = ");
Console.WriteLine(B);
Console.Write("Max = ");
Console.Write(A);
}
else 
{
Console.Write($"a = ");
Console.WriteLine(A);
Console.Write($"b = ");
Console.WriteLine(B);
Console.Write("Max = ");
Console.Write(B);
}