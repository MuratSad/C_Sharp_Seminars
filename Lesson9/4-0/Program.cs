// 4. Напишите программу, которая на вход принимает два числа A и B,
//    и возводит число А в целую степень B с помощью рекурсии.

int ReCursion(int A, int B)
{
    if (B == 0) return 1;
    ReCursion(A, B - 1);

    return ReCursion(A, B - 1) * A;
}
Console.WriteLine("Введите целое число A");
int A=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите целое число B");
int B=int.Parse(Console.ReadLine()!);
Console.Write($"Результат возведения числа А={A} в степень B={B} => {ReCursion(A, B)}");