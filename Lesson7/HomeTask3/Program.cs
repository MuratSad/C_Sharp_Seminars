// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
void SredneArifmeticEveryColumnInArray(int[,]array)
{
    double temp=0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j=0;j<array.GetLength(1);j++)
    {
        for (int i=0;i<array.GetLength(0);i++)
        {
           temp = temp + array[i,j];
        }
        Console.Write($" {Math.Round(temp/array.GetLength(0),1)};");
        temp = 0;
    }
}
Console.WriteLine("Введите целое число, количество строк двумерного массива M");
int arrayRow = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите целое число, количество столбцов двумерного массива N");
int arrayColumn = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное целое число генератора чисел");
int minValue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное целое число генератора чисел");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array=CreateMassive(arrayRow,arrayColumn,minValue,maxValue);
PrintArray(array);
Console.WriteLine("");
SredneArifmeticEveryColumnInArray(array);