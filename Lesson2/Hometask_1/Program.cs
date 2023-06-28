// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число = ");
int num = int.Parse(Console.ReadLine()!);
while (num>999|num<100)
{
      Console.WriteLine("Введите трехзначное число = ");
      num = int.Parse(Console.ReadLine()!);
}
int second_digit = (num-(num-num%100))/10;
Console.WriteLine($"{num} -> {second_digit}");


