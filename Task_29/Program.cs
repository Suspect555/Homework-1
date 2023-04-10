// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("enter array size");
int size = int.Parse(Console.ReadLine());

int [] array =FilledArray(size);

PrintArray (array);

int []FilledArray(int size)
{
    int [] array = new int [size];

    for (int i = 0; i < array.Length; i++)
{
Console.Write($"enter element {i+1} -> ");
      array [i] = int.Parse(Console.ReadLine());
}   
  return array;
}

void PrintArray(int [] array)

{
    for (var i = 0; i < array.Length; i++)
    {

        Console.Write(array[i]);
    }
}
