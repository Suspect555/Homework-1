// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


Console.WriteLine("Enter 2D massive elements");

Console.WriteLine("Enter m element");

int m = int.Parse(Console.ReadLine());

Console.WriteLine("Enter n element");

int n = int.Parse(Console.ReadLine());

double[,] matrix = new double[m,n];


void PrintArray(double[,] matr)
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

FillArray(matrix);

void FillArray(double[,] matr)
{


    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            // Console.Write("Enter  real number -> ");
                                                                  // Заполнение массива вручную.
            // matr[i, j] = double.Parse(Console.ReadLine()); 

            matr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
Console.WriteLine($" m = {m}    n = {n}");
Console.WriteLine();
PrintArray(matrix);