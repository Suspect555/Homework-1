// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter M Number");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Enter M Number");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"M = {M};N = {N} -> ");

Print();
void Print()
{
    if(M==N+1)
    {
        return;
    }
    Console.Write($"{M} ");
    M++;
    Print();


}