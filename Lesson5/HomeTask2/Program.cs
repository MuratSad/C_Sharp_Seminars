// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
void PrintMassive(int[] Array) // печать масссива натуральных чисел на экран
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}|");
    }
    Console.WriteLine("");
}
void SumResult(int[] arr) //Суммирование нечетных чисел в массиве
{
    int sum=0;
    for (int i=0;i<arr.Length;i+=2)
    {
        sum=sum+arr[i];
    }
    Console.WriteLine($"сумма чисел на нечетных местах->{sum}");
}
int[] Array = CreateMassive();
PrintMassive(Array);
SumResult(Array);