// Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.

int sum (int num)
{
    int result=0;
    for (int i=0;i<=num;i++)
    {
    result=result+i;
    }
    return result;
}
int A=int.Parse(Console.ReadLine());
sum(A);
