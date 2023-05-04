// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter M Number");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Enter N Number");
int N = int.Parse(Console.ReadLine());

int result = GetResult(M,N);

Console.WriteLine($"M = {M}; N = {N} -> {result + M}");

int GetResult(int M, int N)
{
   int res = M;

    if (M == N) return 0;
    else
    {
        M++;
        res = M + GetResult(M, N);
        return res;
    }

}

