// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());
int length = GetLengthNumber(number);
int [] array = ConvertToArray(number);
int sum = SumOfNumbers(array);

Console.WriteLine($"{number} -> {sum}");

int SumOfNumbers(int [] array)
{
    int result = 0;

    for ( int i = 0; i < array.Length; i++ )
    {
        result += array[i];
    }

    return result;
}

int GetLengthNumber(int number) 
{
    int length = 0;
    while (number != 0)
    {                                    
        number = number /10;
        length++;
    }
       return length;
}

int[] ConvertToArray(int number) 
{
    int length = GetLengthNumber(number);
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = number % 10;
        number = number /10;
    }
return result;
}

