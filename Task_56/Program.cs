// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int SumLineElements(int[,] matr, int i)
{
    int sumLine = matr[i, 0];
    for (int j = 1; j < matr.GetLength(1); j++)
    {
        sumLine += matr[i, j];
    }
    return sumLine;
}

int x = 4;
int y = 4;
int[,] matrix = new int[x, y];
int result = 0;
int sumLine = SumLineElements(matrix, 0);

for (int i = 1; i < matrix.GetLength(0); i++)
{
    int t = SumLineElements(matrix, i);

    if (sumLine > t)
    {
        sumLine = t;
        result = i;
    }
}

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine($"Minimal summ of the elements in {result + 1}th- string");

