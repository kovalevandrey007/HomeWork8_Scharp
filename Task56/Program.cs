/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей 
суммой элементов: 1 строка*/


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

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($" {array[i,j]} ");
    }
    Console.WriteLine();
  }
}

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int [,] SumMinElem(int[,] array)
{
int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
    {
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine)
        {
        sumLine = tempSumLine;
        minSumLine = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Cтрокa с наименьшей суммой - {minSumLine+1} и суммой элеметов = {sumLine}");
    return array;
}

int m = GetNumber("Введите количество строк m: ");
int n = GetNumber("Введите столбцов n: ");
int [,] array = GetArray(m, n);
Console.WriteLine("\nПолученный массив: ");
PrintArray(array);
int [,]sum = SumMinElem(array);
