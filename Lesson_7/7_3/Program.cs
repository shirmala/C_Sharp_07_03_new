// Задача 7_3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.
//    https://4apple.org/summa-diagonalnyh-jelementov-matricy/
//    https://ru.wikipedia.org/wiki/%D0%93%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D0%B4%D0%B8%D0%B0%D0%B3%D0%BE%D0%BD%D0%B0%D0%BB%D1%8C

void Print(int[,] arr)
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
int[,] MassNums(int row, int column, int from, int to)
{
      int[,] arr = new int[row, column];

      for (int i = 0; i < row; i++)
            for (int j = 0; j < column; j++)
                  arr[i, j] = new Random().Next(from, to + 1);
      return arr;
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

Console.Write("Кол-во элементов в строке:");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во элементов в столбце:");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Начало диапозона:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Конец диапозона:");
int b = int.Parse(Console.ReadLine()!);

int[,] MakeArray(int x, int y, int m, int n)
{
      int[,] array = new int[x, y];

      for (int i = 0; i < x; i++)
      {
            for (int j = 0; j < y; j++)
            {
                  array[i, j] = new Random().Next(m, n + 1);
            }
      }
      return array;
}
void PrintArray(int[,] arr)
{
      for (int i = 0; i < arr.GetLength(0); i++)
      {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                  Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
      }
      Console.WriteLine();
}
int[,] array = MakeArray(x, y, a, b);
PrintArray(array);

int Sum(int[,] arr)
{
      int sum = 0;
      for (int i = 0; i < arr.GetLength(0); i++)
      {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                  if (i == j) sum += arr[i, j];// суть задачи
            }
      }
      return sum;
}
Console.WriteLine(Sum(array));

