// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void ResultMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            int mult = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                mult = matrix1[i, j] * matrix2[i, j];
            }
            matrix3[i, j] = mult;
        }
    }
}

int x = 2;
int y = 2;
int[,] matrix1 = new int[x, y];
int[,] matrix2 = new int[x, y];
int[,] matrix3 = new int[x, y];

FillArray(matrix1);
FillArray(matrix2);
ResultMatrix(matrix1, matrix2, matrix3);
Console.WriteLine();
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(matrix3);
