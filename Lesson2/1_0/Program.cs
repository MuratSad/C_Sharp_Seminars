// See https://aka.ms/new-console-template for more information

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}
int num_gen = new Random().Next(100,1000);
int result = TakeNum(num_gen);
Console.WriteLine(result);