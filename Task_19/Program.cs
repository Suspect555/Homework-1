// Задача 19
//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 12821 -> да; 23432 -> да

Console.WriteLine("Введите пятизначное число");
int N = int.Parse(Console.ReadLine());

int last = ((N % 100)%10);
int first = ((N/10000));
int two =  ((N/1000)%10);
int fore = ((N % 100)/10);
if ( N <=10000 | N > 100000)
{
    Console.WriteLine("Это не пятизначное число");
    return;
}

if( first == last & two == fore)
    {
        Console.Write($"{N} -> да");
    }
    else
    {
        Console.Write($"{N} -> нет");
    }







