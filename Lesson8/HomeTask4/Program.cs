// Задача 59. Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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
void FindMinValueEndDeleteNumbers(int[,] Array) // необходимый метод домашнего задания
{
    int row = Array.GetLength(0);
    int column = Array.GetLength(1);
    int minValue = Array[0, 0];
    int minRow = 0;
    int minCol = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (Array[i, j] < minValue)
            {
                minValue = Array[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
    Console.WriteLine($"Минимальное значение = {minValue} строка {minRow + 1} столбец {minCol + 1}");
    Console.WriteLine("Результат удаления строк и столбцов в этой точке");
    int[,] newArray = new int[row - 1, column - 1];
    int newRow = 0;
    int newColumn = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (i == minRow || j == minCol)
            {
                continue;
            }
            else
            {
                newArray[newRow, newColumn] = Array[i, j];
                newColumn++;
                if (newColumn == column - 1)
                {
                    newColumn = 0;
                    newRow++;
                }
            }
        }
        
    }
    PrintArray(newArray);
}


Console.WriteLine("Количество строк матрицы");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов матрицы");
int column = int.Parse(Console.ReadLine()!);
int[,] Array = new int[row, column];
Console.WriteLine("минимальное число случайных целых чисел");
int minValue = int.Parse(Console.ReadLine()!); ;
Console.WriteLine("максимальное число случайных целых чисел");
int maxValue = int.Parse(Console.ReadLine()!); ;
Array = CreateMassive(row, column, minValue, maxValue);
Console.WriteLine("Сгенерированная матрицв целых чисел");
PrintArray(Array);
FindMinValueEndDeleteNumbers(Array);
