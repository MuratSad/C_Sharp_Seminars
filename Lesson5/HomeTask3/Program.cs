
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

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
void Result(double[] Array) //Метод поиска максимального и минимального значений и вывода разницы между ними
{
    int size = Array.Length;
    double MinValue = Array[0];
    double MaxValue = Array[1];
    for (int i = 0; i < size; i++)
    {
        if (Array[i] > MaxValue) MaxValue = Array[i];
        if (Array[i] < MinValue) MinValue = Array[i];
    }
    Console.WriteLine($"=>{MaxValue} - {MinValue} = {MaxValue-MinValue}");
}
double[] array = CreateDoubleTypeMassive(0, 1, 100);  //объявление массива вещественных чисел
PrintMassive(array);  //печать массива
Result(array);  // вызов метода Result
