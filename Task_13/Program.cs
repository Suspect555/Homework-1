// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");


int num = int.Parse(Console.ReadLine());


if(num>=100 & num <=1000) //3
{
    int lastDigit = num % 10;
    
    Console.WriteLine($"{num} -> {lastDigit}");
}
if(num>=1000 & num <=10000) //4
{
    int firstDigit = num % 100;
    int lastDigit = firstDigit / 10;

    Console.WriteLine($"{num} -> {lastDigit}");
}
if(num>=10000 & num <=100000) //5
{
    int firstDigit = num % 1000;
    int lastDigit = firstDigit / 100;

    Console.WriteLine($"{num} -> {lastDigit}");
}
if(num>=100000 & num <=1000000) //6
{
    int firstDigit = num % 10000;
    int lastDigit = firstDigit / 1000;

    Console.WriteLine($"{num} -> {lastDigit}");
}
if (num<100)
{
    Console.WriteLine($"{num} -> Третьей цифры нет");
}

