// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter A Number");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter B Number");
int B = int.Parse(Console.ReadLine());

int result = GetResult(A,B);
Console.WriteLine($"A = {A}; B = {B} -> {result}");

int GetResult(int A, int B)
{

    if (B ==1) return A;
    else
    {
        return A+GetResult(A, B-1);
    }

}

