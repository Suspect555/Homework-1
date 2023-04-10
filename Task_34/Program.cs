// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int[7];
FillArray(array);
int result = EvenNumbers(array);
PrintArray(array);


void FillArray(int [] array)
{
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rand.Next(100,1000);
    }

}

int EvenNumbers(int [] array)
{
    result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]% 2 == 0)
        {
        result ++;
        }

    }
    return result;
}


void PrintArray(int [] array)
{
     Console.Write($"[{string.Join(", ",array)}] -> {result} ");
}
