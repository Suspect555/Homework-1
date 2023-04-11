// Задача 41: Пользователь вводит c клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите числа");
int [] mass = new int[M];
int count = 0;
for (int i = 0; i<M; i++)
{
   mass[i] = int.Parse(Console.ReadLine());
   if (mass[i]>0)
   {
    count++;
   }
}

Console.Write($"[{string.Join("," , mass)}]  -> {count}");

