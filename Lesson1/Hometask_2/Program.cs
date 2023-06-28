// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число  = ");
int [] Array = new int [3];
Array [0] = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число  = ");
Array [1] = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число  = ");
Array [2] = int.Parse(Console.ReadLine()!);
int max=Array[0];
int index=0;
while (index<3)
{
    if(Array[index]>max)
    max=Array[index];
    index+=1;
}
Console.WriteLine($"max = {max}");