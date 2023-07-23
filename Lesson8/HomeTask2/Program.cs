// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMassive(int row, int column, int minValue, int maxValue) //Метод для создания 2-мерного массива целых чисел
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}
void PrintArray(int[,] array)   //вывод на экран двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
}
void FindMinSummInRow(int[,] array)
{
    int minSumm = 0;
    int tempSumm = 0;
    int indexMinSumm = 0;
    int oneStep = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        tempSumm = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSumm = tempSumm + array[i, j];
        }
        if (oneStep == 0)
        {
            minSumm = tempSumm;
            oneStep = 1;
        }
        if (tempSumm < minSumm)
        {
            minSumm = tempSumm;
            indexMinSumm = i + 1;
        }
    }
    Console.WriteLine($"Минимальная сумма в строке  {indexMinSumm}");
}


int[,] Array = new int[4, 4];
Array = CreateMassive(4, 4, 1, 10); // создаем массив размерностью 4х4 с генерацией чисел от 1 до 10
PrintArray(Array);
FindMinSummInRow(Array);
