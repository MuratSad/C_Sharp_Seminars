// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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

Console.WriteLine("Введите целое число, количество строк двумерного массива M");
int arrayRow = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите целое число, количество столбцов двумерного массива N");
int arrayColumn = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное целое число генератора чисел");
int minValue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное целое число генератора чисел");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array=CreateMassive(arrayRow, arrayColumn, minValue, maxValue);
PrintArray(array);
