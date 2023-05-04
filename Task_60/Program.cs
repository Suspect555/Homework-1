// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

void FillArray(int[,,] matr)
{
    int[] tmp = new int[matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2)];
    int number;
    for (int i = 0; i < tmp.GetLength(0); i++)
    {
        tmp[i] = new Random().Next(10, 100);
        number = tmp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tmp[i] == tmp[j])
                {
                    tmp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = tmp[i];
                }
                number = tmp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < matr.GetLength(0); x++)
    {
        for (int y = 0; y < matr.GetLength(1); y++)
        {
            for (int z = 0; z < matr.GetLength(2); z++)
            {
                matr[x, y, z] = tmp[count];
                count++;
            }
        }
    }
}

int x = 2;
int y = 2;
int z = 2;
int[,,] matrix = new int[x, y, z];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/
int [,,] matrix = Generate3DMatrix();
PrintArray(matrix);


int [,,] Generate3DMatrix()
 
{
    int [,,]result = new int[2,2,2];

    HashSet<int> hashSet = new HashSet<int>();


    Random random = new Random();
    
        for (var i=0; i < result.GetLength(0); i++) 
        {
            for (var j=0; j < result.GetLength(1); j++)
            {
                for (var k=0; k < result.GetLength(2); k++)
                {
                    while(true)          // Генерация уникальных рандомных чисел на позициях по очереди
                    {
                        int number = random.Next(10,100);
                        bool isExists = hashSet.TryGetValue(number ,  out int _);

                        if (!isExists)
                        {
                            result  [i,j,k] = number;
                            hashSet.Add(number);
                            break;
                        }
         
                    }
                    


                    // result[i,j,k] = random.Next(10,100); Генерация рандомных чисел на позициях по очереди
                 
                }
            }
        }

        return result;
    
}

void PrintArray(int [,,]matrix)
{
           for (var i=0; i < matrix.GetLength(0); i++) 
        {
            for (var j=0; j < matrix.GetLength(1); j++)
            {
                for (var k=0; k < matrix.GetLength(2); k++)
                {
            
                 Console.Write($"{matrix[i,j,k]} ({i},{j},{k}); ");

                }
                Console.WriteLine();
            }
        }
}