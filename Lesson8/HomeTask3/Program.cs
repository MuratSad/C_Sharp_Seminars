// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] ProizvedenieMassive(int[,] array1, int[,] array2)   //умножение массивов целых чисел
{
    int row1 = array1.GetLength(0);
    int row2 = array2.GetLength(0);
    int column1 = array1.GetLength(1);
    int column2 = array2.GetLength(1);
    if (column1 != row2)     //проверка условия для умножения матриц
    {
        Console.WriteLine("Неправильные размерности массивов для умножения");
        return array1;
    }
    else
    {
        int[,] newArray = new int[row1, column2];
        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < column2; j++)
            {
                for (int k = 0; k < column1; k++)
                {
                    newArray[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
        return newArray;
    }
}

Console.WriteLine("Для умножения матрицы целых чисел введите параметры матрицы Количество строк и столбцов");
Console.WriteLine("Количество строк первой матрицы");
int row1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов первой матрицы");
int column1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество строк второй матрицы");
int row2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов второй матрицы");
int column2 = int.Parse(Console.ReadLine()!);


int[,] Array1 = new int[row1, column1];
int[,] Array2 = new int[row2, column2];
Array1 = CreateMassive(row1, column1, 1, 10); // создаем массив 1 с заданной размерностью и генерацией чисел от 1 до 10
Array2 = CreateMassive(row2, column2, 1, 10); // создаем массив 2 с заданной размерностью и генерацией чисел от 1 до 10
PrintArray(Array1);
Console.WriteLine();
PrintArray(Array2);
Console.WriteLine();
PrintArray(ProizvedenieMassive(Array1, Array2));