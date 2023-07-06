// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число в диапазоне от 0 до 99999 = ");
int num = int.Parse(Console.ReadLine()!);
while (num < 0 | num > 99999)
{
    Console.WriteLine($"число {num} не входит в заданный диапазон");
    num = int.Parse(Console.ReadLine()!);
}
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (num>100&&num<1000)
{
    int result = num % 10;
    Console.WriteLine($"{num} -> {result}");
}
else if (num > 999 && num < 10000)
{
    int result = (num / 10) % 10;
    Console.WriteLine($"{num} -> {result}");
}
else
{
    int result = (num / 100) % 10;
    Console.WriteLine($"{num} -> {result}");
}