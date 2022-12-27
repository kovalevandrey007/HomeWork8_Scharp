/*Задача 54. Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой 
строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int GetNumber(string text) 
{ 
    int result = 0; 
    Console.WriteLine(text); 
    while(true) 
    { 
    if (int.TryParse(Console.ReadLine(), out result)) 
        { 
        break; 
        } 
        else 
        { 
        Console.WriteLine("Ввели не число. Введите число: "); 
        } 
    } 
return result; 
} 

int[,] GetArray(int m, int n) 
{
  int[,] array = new int[m,n]; 
  Random rnd = new Random(); 
  for (int i = 0; i < m; i++) 
    { 
    for (int j = 0; j < n; j++) 
        { 
        array[i,j] = rnd.Next(0, 10); 
        } 
    } 
return array; 
} 


int [,] SortMin(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
return array;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}


int m = GetNumber("Введите число строк m: ");
int n = GetNumber("Введите число столбцов n: ");
int[,] array = GetArray(m,n);
Console.WriteLine($"\nПолучившийся массив: ");
PrintArray(array);
Console.WriteLine($"\nОтсортированный массив: ");
int [,] resultArr = SortMin(array);
PrintArray(resultArr);