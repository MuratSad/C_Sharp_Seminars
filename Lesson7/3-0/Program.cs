// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.
//    https://4apple.org/summa-diagonalnyh-jelementov-matricy/
//    https://ru.wikipedia.org/wiki/%D0%93%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D0%B4%D0%B8%D0%B0%D0%B3%D0%BE%D0%BD%D0%B0%D0%BB%D1%8C

int DiagonalSum(int[,] arr)
{
    int res = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        res += arr[i, i];
    }
    return res;
}

void Sum_massive(int[,] array)
{
    int sum = 0;
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("не будет ровной диагонали");
        return;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (i == j)
            {
                sum = sum + array[i, j];
            }


        }
    }
    Console.Write($"{sum}");

}