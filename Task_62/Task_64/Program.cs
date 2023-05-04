// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Enter Number");

int N = int.Parse(Console.ReadLine());
int GetResult = GetResult(N);
Console.WriteLine($"N = {N} -> ");

int GetResult(int N);
{
    if (N ==0) return N;
    else
    {
        return A*GetResult(A, B-1);
    }

}