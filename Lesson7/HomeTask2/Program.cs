// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
int FindValueFromArray (int[,] array,int row,int column)
{
    int arrayRow=array.GetLength(0);
    int arrayColumn=array.GetLength(1);
   if (row>arrayRow||row<0||column>arrayColumn||column<0)
   {
    Console.WriteLine("запрос за пределами размерности массива");
    return 0;
   }
   else 
   {
    return array[row-1,column-1];
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
Console.WriteLine("Введите нужную строку и столбец в массиве значение должно быть целым числом");

int rowNum = int.Parse(Console.ReadLine()!);
int columnNum = int.Parse(Console.ReadLine()!);
int Num = FindValueFromArray(array,rowNum,columnNum);
Console.WriteLine($"значение равно {Num}");