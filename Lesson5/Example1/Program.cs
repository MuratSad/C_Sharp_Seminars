// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int [] CreateMassive(int Size,int MinValue,int MaxValue) //Функция для создание массива целых чисел (размерностью Size,минимальным значением рандомайзера MinValue,и максимальным значением MaxValue)
{
 int[] Array =new int [Size];
 for (int i=0;i<Size;i++)
 {
    Array[i]=new Random().Next(MinValue,MaxValue);
 }
 return Array;
}
void SumPosNeg(int[] Array)
{
int pos=0;
int neg=0;
for (int i=0;i<Array.Length;i++)
{
    if (Array[i]>=0)
    pos=pos+Array[i];
    else
    neg=neg+Array[i];
}
Console.WriteLine($"neg={neg}");
Console.WriteLine($"pos={pos}");
}
SumPosNeg(CreateMassive(12,-9,10));
