// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter A number");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter B number");
int B = int.Parse(Console.ReadLine());

int result = Stepen(A,B);
Console.WriteLine($"{A}, {B} -> {result}");

int Stepen (int number1,int number2)
{
    int result = 1;
for (int i = 1; i <= number2; i++)
{
    result = result * number1;
    
}
return result;

}
