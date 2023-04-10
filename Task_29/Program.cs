// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("enter array size");
int size = int.Parse(Console.ReadLine());

int [] array = RandomArray(size);
PrintArray (array);

int [] RandomArray(int size)
{
    int [] array = new int [size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)

      array [i] = rand.Next();
    
  return array;
}
void PrintArray(int [] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
