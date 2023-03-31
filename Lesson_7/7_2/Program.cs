//Задача 7_2. Задайте двумерный массив. Найдите элементы,
//    у которых обе позиции чётные, и замените эти элементы
// на их квадраты.

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

int[,] MyFunc(int[,] arr)
{
      for (int i = 1; i < arr.GetLength(0); i += 2)
      {
            for (int j = 1; j < arr.GetLength(1); j += 2)
            {
                  arr[i, j] *= arr[i, j];// суть задачи
            }
      }
      return arr;
}
PrintArray(MyFunc(array));





