// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateMassive(int Size,int MinValue,int MaxValue) //Функция для создание массива целых чисел (размерностью Size,минимальным значением рандомайзера MinValue,и максимальным значением MaxValue)
{
 int[] Array =new int [Size];
 for (int i=0;i<Size;i++)
 {
    Array[i]=new Random().Next(MinValue,MaxValue);
 }
 return Array;
}
void PrintMassive(int []Array) // печать масссива натуральных чисел на экран
{
 for (int i=0;i<Array.Length;i++)
 {
   Console.Write($"{Array[i]}|");
 }
}
Console.WriteLine("Введите размер массива Size");
int Size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение диапазона чисел рандомайзера MinValue");
int MinValue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите макимальное значение диапазона чисел рандомайзера MaxValue");
int MaxValue = int.Parse(Console.ReadLine()!);
PrintMassive(CreateMassive(Size,MinValue,MaxValue));
