// Задайте двумерный массив. Найдите элементы, у которых
	// обе позиции чётные, и замените эти элементы на их квадраты.
	
	void PrintArray(int[,] matr)
	{
	    for (int i = 0; i < matr.GetLength(0); i++)
	    {
	        for (int j = 0; j < matr.GetLength(1); j++)
	        {
	            Console.Write($"{matr[i, j], 3} ");
	        }
	        Console.WriteLine();
	    }
	}
	
	void FillArray(int[,] matr, int min, int max)
	{
	    Console.WriteLine("\nМассив:");
	    for (int i = 0; i < matr.GetLength(0); i++)
	    {
	        for (int j = 0; j < matr.GetLength(1); j++)
	        {
	            matr[i, j] = new Random().Next(min, max + 1);
	        }
	    }
	}
    void SqareOfEven(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            if (i % 2 == 1 && j % 2 == 1)
	                array[i, j] = array[i, j] * array[i, j];
	        }
	    }
	}
	
	Console.WriteLine("Введите количество строк ");
	int m = int.Parse(Console.ReadLine()!);
	Console.WriteLine("Введите количество столбцов ");
	int n = int.Parse(Console.ReadLine()!);
	int[,] matrix = new int[m, n];
	Console.Write("Введите минимальное значение элемента массива : ");
	int start = int.Parse(Console.ReadLine()!);
	Console.Write("Введите максимальное значение элемента массива : ");
	int stop = int.Parse(Console.ReadLine()!);
	FillArray(matrix, start, stop);
	PrintArray(matrix);
	SqareOfEven(matrix);
	Console.WriteLine("\nНовый массив: ");
	PrintArray(matrix);