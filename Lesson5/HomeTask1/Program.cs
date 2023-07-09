// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void PrintMassive(int[] Array) // печать масссива натуральных чисел на экран
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}|");
    }
    Console.WriteLine("");
}
int[] CreateMassive(int Size = 0, int MinValue = 0, int MaxValue = 0) //Функция для создание массива целых чисел (размерностью Size,минимальным значением рандомайзера MinValue,и максимальным значением MaxValue)

{
    if (Size == 0)
    {
        while(Size<=0)
        {
        Console.Write("Введите размерность массива = ");
        Size = int.Parse(Console.ReadLine()!);
        }
        while(MinValue==0)
        {
        Console.Write("Введите минимальное значение диапазона чисел=");
        MinValue = int.Parse(Console.ReadLine()!);
        }
        while(MaxValue==0)
        {
        Console.Write("Введите максимальное значение диапазона чисел=");
        MaxValue = int.Parse(Console.ReadLine()!);
        }
    }

    int[] Array = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        Array[i] = new Random().Next(MinValue, MaxValue);
    }
    return Array;
}
void CountOfChetnyhValue(int[] arr) //подсчет количества положительных значений в массиве
{
    int count = 0;
    int lenght = arr.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Количество четных чисел = {count}");
}
int[] Array = CreateMassive();
PrintMassive(Array);
CountOfChetnyhValue(Array);
