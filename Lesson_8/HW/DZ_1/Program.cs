/*Задача DZ_1.
Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

//Вариант_1:
void Printa(int[,] arr)
{
      int row_size = arr.GetLength(0);
      int column_size = arr.GetLength(1);

      for (int i = 0; i < row_size; i++)
      {
            for (int j = 0; j < column_size; j++)
                  Console.Write($" {arr[i, j]} ");
            Console.WriteLine();
      }
      Console.WriteLine();
}

int[,] MassNumsa(int row, int column, int from, int to)
{
      int[,] arr = new int[row, column];

      for (int i = 0; i < row; i++)
            for (int j = 0; j < column; j++)
                  arr[i, j] = new Random().Next(from, to);
      return arr;
}
void DecreasingNum(int[,] arr)
{
      int a = arr.GetLength(0);
      int b = arr.GetLength(1);
      for (int i = 0; i < a; i++)
            for (int k = 0; k < b - 1; k++)
                  for (int j = 0; j < b - 1; j++)
                        if (arr[i, j] < arr[i, j + 1])
                        {
                              int t = arr[i, j];
                              arr[i, j] = arr[i, j + 1];
                              arr[i, j + 1] = t;
                        }
}
Console.Write("Enter the number of rows: ");
int row_numa = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_numa = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int starta = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stopa = int.Parse(Console.ReadLine()!);

int[,] massa = MassNumsa(row_numa, column_numa, starta, stopa);

Printa(massa);
DecreasingNum(massa);
Printa(massa);

//Вариант_2 от преподавателя:
void Print(int[,] arr)
{
      int row_size = arr.GetLength(0);
      int column_size = arr.GetLength(1);

      for (int i = 0; i < row_size; i++)
      {
            for (int j = 0; j < column_size; j++)
                  Console.Write($" {arr[i, j],3} ");
            Console.WriteLine();
      }
      Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
      int[,] arr = new int[row, column];

      for (int i = 0; i < row; i++)
            for (int j = 0; j < column; j++)
                  arr[i, j] = new Random().Next(from, to + 1);
      return arr;
}

void OrderElMin(int[,] arr)
{
      int row_size = arr.GetLength(0);
      int column_size = arr.GetLength(1);

      for (int i = 0; i < row_size; i++)
      {
            for (int j = 0; j < column_size; j++)
            {
                  for (int k = 0; k < column_size - j - 1; k++)
                        if (arr[i, k] < arr[i, k + 1])
                              (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
            }
      }
}
Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
OrderElMin(mass);
Print(mass);

