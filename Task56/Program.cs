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

/*Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет 
строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя. */

//1.функция получения массива
//2.функция замены строки на столбцы
//3.функция замены
//4.функция печати массива


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
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n]; 
    Random rnd = new Random(); 
    for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(1, 10); 
                } 
        }
        return array; 
} 
void reverse(int[,] arr)
{
        int[,] arrayreverse = new int [arr.GetLength(1), arr.GetLength(0)];
        for (int i = 0; i < arrayreverse.GetLength(0); i++)
            {
                for (int j = 0; j < arrayreverse.GetLength(1); j++)
                        {
                            arrayreverse[i, j] = arr[j, i]; 
                        }
            }
        PrintArray(arrayreverse);
}
int[,] matrix = GetArray(2, 5); 
PrintArray (matrix); reverse(matrix); 