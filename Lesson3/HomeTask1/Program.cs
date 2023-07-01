// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string PalindromCheck(int Number)
{
    if (Number/10000 == Number%10 && (Number%10000)/1000 == (Number%100)/10)
    {
        
        return "Число является палиндромом.";
    }

    else
        return "Число не является палиндромом.";
}

Console.WriteLine("Проверка пятизначного числа на палиндромность");
int Num=0;
while (Num > 99999 || Num < 10000)
{
    Console.WriteLine("Введите 5-ти значное число");
    Num = int.Parse(Console.ReadLine()!);
}
int result=Num/10000;
Console.WriteLine($"{result}");
Console.WriteLine(PalindromCheck(Num));