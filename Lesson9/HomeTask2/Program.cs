// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int PrintSumOfNumbers(int num1,int num2,int sum=0)
{
     if (num1 % 2 == 0)
    {
        sum=sum+num1;
    }
    if (num2==num1) return sum;
    num1=num1+1;
    PrintSumOfNumbers(num1,num2,sum);
    return sum;
}


Console.WriteLine("введите целое число M");
int m=int.Parse(Console.ReadLine()!);
Console.WriteLine("введите целое число N");
int n=int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintSumOfNumbers(m,n));