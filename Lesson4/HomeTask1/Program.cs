// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Qub (int A,int B)
{
    int result = A;
    for (int i=1;i<B;i++)
    {
        result=result*A;
    }
    return result;
}
Console.WriteLine("Введите натуральное число A");
int A =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите натуральное число B");
int B =int.Parse(Console.ReadLine()!);
Console.WriteLine($"{A}, {B} -> {Qub (A,B)}");
