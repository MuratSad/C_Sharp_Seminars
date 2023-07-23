// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//  по убыванию элементы каждой строки двумерного массива.
//  Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
int[,] SortArray(int[,] array)
{
    int tempArrayRow = array.GetLength(0);
    int tempArrayColumn = array.GetLength(1);
    for (int i = 0; i < tempArrayRow; i++)
    {
        for (int j = 0; j < tempArrayColumn - 1; j++)
        {

            for (int k = 0; k < tempArrayColumn - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    (array[i, k], array[i, k + 1]) = (array[i, k + 1], array[i, k]);
                }
            }
        }
    }
    return array;
}
int[,] Array = new int[4, 4];
Array = CreateMassive(4, 4, 1, 20); // создаем массив размерностью 4х4 с генерацией чисел от 1 до 20
PrintArray(Array);
Console.WriteLine();
PrintArray(SortArray(Array));