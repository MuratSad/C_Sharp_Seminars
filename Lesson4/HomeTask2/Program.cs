// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите натуральное число Num");
int Num = int.Parse(Console.ReadLine()!);
int GetLenghtOfInt(int A)
{
    int Count = 0;
    int x = A;
    while (x != 0)
    {
        x = x / 10;
        Count++;
    }

    return Count;
}
int SumOfDigits (int B)
{
    int result = 0;
    for (int j=10;B!=0;)
    {
        result=result+B%j;
        B=B/10;
    }
    
    return result;
}
Console.Write(SumOfDigits(Num));

