// Задача 50. Напишите программу,
// которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Enter position of element");

Console.WriteLine("Enter string number");

int x = int.Parse(Console.ReadLine());

Console.WriteLine("Enter colum number");

int y = int.Parse(Console.ReadLine());

int[,] matrix = new int[3,4];
FillArray(matrix);
Console.WriteLine();

if (x > matrix.GetLength(0) || y > matrix.GetLength(1))
{
    Console.WriteLine($"x = {x}  y = {y} -> There is no such position");
}
else
{
    Console.WriteLine($"x = {x}  y = {y}  -- The number on position is -> {matrix[x-1,y-1]}");
}

Console.WriteLine();
PrintArray(matrix);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-100, 100)/10; 
        }
    }
}

