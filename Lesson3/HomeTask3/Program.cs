// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
void QUB (int X,int y=1)
{
  while (y<=X)
  {
    int result=y*y*y;
    Console.Write(","+result);
    y+=1;
  }
}
QUB(N);
