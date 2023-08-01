// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// (первое == последнему, второе == предпоследнему).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine()!);
string numStr = num.ToString();
if (numStr.Length == 5)
{
    if (numStr[0] == numStr[4] & numStr[1]==numStr[3])
    {
        Console.WriteLine("Число является палинромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    
    }
}
