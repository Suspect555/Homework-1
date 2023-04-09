// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("enter x_A");
int x_A = int.Parse(Console.ReadLine());
Console.WriteLine("enter y_A");
int y_A = int.Parse(Console.ReadLine());
Console.WriteLine("enter z_A");
int z_A = int.Parse(Console.ReadLine());
Console.WriteLine("enter x_B");
int x_B = int.Parse(Console.ReadLine());
Console.WriteLine("enter y_B");
int y_B = int.Parse(Console.ReadLine());
Console.WriteLine("enter y_B");
int z_B = int.Parse(Console.ReadLine());

double result = GetRange(x_A,y_A,z_A,x_B,y_B,z_B);

Console.WriteLine($"A ({x_A}, {y_A}, {z_A}); B ({x_B}, {y_B}, {z_B}) -> {result}");

double GetRange(int x_A, int y_A,int z_A, int x_B, int y_B, int z_B)
{
    result = Math. Sqrt((x_B - x_A) * (x_B - x_A) + (y_B - y_A) * (y_B - y_A) + (z_B - z_A) * (z_B - z_A));
    
    return result;
}

