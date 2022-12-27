/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


int[,] arr1 = {{1, 2, 3},
               {4, 5, 6},
               {7, 8, 9}};


Console.WriteLine("\nПервая матрица: ");
void PrintArray1(int[,] arr1)
{
  for (int i = 0; i < arr1.GetLength(0); i++)
  {
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
      Console.Write(arr1[i, j] + " ");
    }
    Console.WriteLine();
  }
}
PrintArray1(arr1);

int[,] arr2 = {{3, 4, 6},
               {7, 2, 1},
               {1, 3, 2}};
 

Console.WriteLine("\nВторая матрица: ");
void PrintArray2(int[,] arr2)
{
  for (int i = 0; i < arr2.GetLength(0); i++)
  {
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
      Console.Write(arr2[i, j] + " ");
    }
    Console.WriteLine();
  }
}
PrintArray2(arr2);

int j;
for (int i = 0; i < 3; i++)
{
for (j = 0; j < 3; j++)
    {
    arr1[i, j] = arr1[i, j] * arr2[i, j];
    }
}

Console.WriteLine("\nПроизведение двух матриц: ");
void PrintArray3(int[,] arr1)
{
  for (int i = 0; i < arr1.GetLength(0); i++)
  {
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
      Console.Write($"{arr1[i, j]} ");
    }
    Console.WriteLine();
  }
}
PrintArray3(arr1);

