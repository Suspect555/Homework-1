// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");

int num = int.Parse(Console.ReadLine());
int firstDigit = num / 10;
int secondDigit = firstDigit % 10;

if(num>=100 & num <=1000)
{
Console.WriteLine($"{num}");
Console.WriteLine($"{secondDigit}");
}
else
{
    Console.WriteLine("Число не является трехзначным");
}
