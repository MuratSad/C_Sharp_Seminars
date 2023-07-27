// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


void PrintNumber(int num1,int num2)
{
    if (num1 % 2 == 0)
    {
        Console.Write($"{num1} ");
    }
    if (num2==num1) return;
    num1=num1+1;
    PrintNumber(num1,num2);
    
}
Console.WriteLine("введите целое число M");
int m=int.Parse(Console.ReadLine()!);
Console.WriteLine("введите целое число N");
int n=int.Parse(Console.ReadLine()!);

PrintNumber(m,n);