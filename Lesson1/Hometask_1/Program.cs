﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

Console.WriteLine("Введите число a = ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b = ");
int B = int.Parse(Console.ReadLine()!);

if (A>B)
{
Console.Write($"a = {A} b = {B} Max = {B}");
}
else if (A==B)
{
Console.WriteLine($"a = {A} b = {B}");
Console.WriteLine("a равно b ");
Console.Write($"{A}={B}");
}
else 
{
Console.Write($"a = {A} b = {B} Max = {B}");
}