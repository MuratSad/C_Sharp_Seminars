// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int PrintSumOfNaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        return 0;
    }
    return num1+PrintSumOfNaturalNumbers(num1+1,num2);
}


Console.WriteLine("введите целое число M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите целое число N");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintSumOfNaturalNumbers(m, n));