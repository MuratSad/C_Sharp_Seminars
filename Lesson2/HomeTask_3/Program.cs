// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int NumberOfDay=0;
while (NumberOfDay<1||NumberOfDay>7)
{
Console.WriteLine("Введите цифру дня недели от 1 до 7");
NumberOfDay = int.Parse(Console.ReadLine()!);
}
switch (NumberOfDay)
{
    case 1: Console.WriteLine($" {NumberOfDay} Выходной? -> нет"); break;
    case 2: Console.WriteLine($" {NumberOfDay} Выходной? -> нет"); break;
    case 3: Console.WriteLine($" {NumberOfDay} Выходной? -> нет"); break;
    case 4: Console.WriteLine($" {NumberOfDay} Выходной? -> нет"); break;
    case 5: Console.WriteLine($" {NumberOfDay} Выходной? -> нет"); break;
    default: Console.WriteLine("-> да"); break;
}