// 4. Найдите произведение пар чисел в одномерном массиве.
//    Парой считаем первый и последний элемент, второй и предпоследний
//    и т.д. Результат запишите в новом массиве.


void PrintMassive(int []Array) // печать масссива натуральных чисел на экран
{
 for (int i=0;i<Array.Length;i++)
 {
   Console.Write($"{Array[i]}|");
 }
 Console.WriteLine("");
}
int[] NewArray(int[] arr) //функция для решения задачи условия
{
    int Length = arr.Length;
    int[] arr_2;

    if (Length % 2 == 0) arr_2 = new int[Length / 2];
    else arr_2 = new int[Length / 2 + 1];
    for (int i = 0; i < arr_2.Length; i++)
    {
        if (arr[i] != arr[Length - i - 1]) arr_2[i] = arr[i] * arr[Length - i - 1];
        else arr_2[arr_2.Length - 1] = arr[i];
    }
    return arr_2;
}
int [] CreateMassive(int Size=0,int MinValue=0,int MaxValue=0) //Функция для создание массива целых чисел (размерностью Size,минимальным значением рандомайзера MinValue,и максимальным значением MaxValue)
{
if (Size==0)
{
    Console.Write("Введите размерность массива = ");
    Size=int.Parse(Console.ReadLine()!);
    Console.Write("Введите минимальное значение диапазона чисел");
    MinValue=int.Parse(Console.ReadLine()!);
    Console.Write("Введите максимальное значение диапазона чисел");
    MaxValue=int.Parse(Console.ReadLine()!);
}

 int[] Array =new int [Size];
 for (int i=0;i<Size;i++)
 {
    Array[i]=new Random().Next(MinValue,MaxValue);
 }
 return Array;
}
int [] array=CreateMassive();
PrintMassive(array);
PrintMassive(NewArray(array));