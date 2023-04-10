// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int[4];
FillArray(array);
int result = EvenNumbers(array);
PrintArray(array);


void FillArray(int [] array)
{
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rand.Next(-10,10);
    }

}

int EvenNumbers(int [] array)
{
    result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
        result += array[i];
        }

    }
    return result;
}


void PrintArray(int [] array)
{
     Console.Write($"[{string.Join(", ",array)}] -> {result} ");
}
