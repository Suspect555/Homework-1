// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] array = new int[5];


FillArray(array); 
PrintArray(array);

int MaxNumber = FindMax(array);
int MinNumber = FindMin(array);
Console.WriteLine(MaxNumber - MinNumber);
Console.WriteLine($"Минимальное число -> {MinNumber}");
Console.WriteLine($"Максимальное число -> {MaxNumber}");

void FillArray(int [] array)
{
    Random mass = new Random();

    for (int i =0; i < array.Length; i++)
    {
        array[i] = mass.Next(0,100);
    }

}

int FindMax(int [] array)
{
    int max = array[0];
    for (int i =0; i < array.Length; i++)
    {
        
        if (array[i]> max)
        {
            max = array[i]; 
        }
        
    }
return max;    
}

int FindMin(int [] array)
{
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        min = array[i];
    }
return min;
}


void PrintArray(int [] array)
{
    Console.Write($"[{string.Join(", ",array)}]  -> ");
}