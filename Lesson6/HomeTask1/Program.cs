// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа, по окончании введите списка чисел введите просто пробел");


string strNumber = string.Empty;
void PrintMassive(double[] Array) // печать масссива вещественных чисел на экран
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}|");
    }
    Console.WriteLine("");
}
double[] CreateDoubleTypeMassive(int Size = 0, double MinValue = 0, double MaxValue = 0) //Функция для создание массива вещественных чисел (размерностью Size,минимальным значением рандомайзера MinValue,и максимальным значением MaxValue)

{
    Random rand = new Random();
    if (Size == 0)
    {
        while (Size <= 0)
        {
            Console.Write("Введите размерность массива = ");
            Size = int.Parse(Console.ReadLine()!);
        }
        while (MinValue == 0)
        {
            Console.Write("Введите минимальное значение диапазона чисел=");
            MinValue = int.Parse(Console.ReadLine()!);
        }
        while (MaxValue == 0)
        {
            Console.Write("Введите максимальное значение диапазона чисел=");
            MaxValue = int.Parse(Console.ReadLine()!);
        }
    }
    double[] arr = new double[Size];
    for (int i = 0; i < Size; i++)
    {
        arr[i] = Math.Round(rand.NextDouble() * (MaxValue - MinValue) + MinValue, 2);
    }
    return arr;
}
void ResultNumbersMoreThanZero(double[] Array) //Метод для подсчета значений выше 0
{
    int size = Array.Length;
    int count=0;
     for (int i = 0; i < size; i++)
    {
        if (Array[i] > 0) count ++;
        
    }
    Console.WriteLine($"Количество значений больше 0  = {count}");
}
double[] array = CreateDoubleTypeMassive(20,-10,30); //задаем массив размером 40, от -10, до 30)
ResultNumbersMoreThanZero(array);
PrintMassive(array);
