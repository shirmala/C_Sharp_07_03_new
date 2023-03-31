//Задача DZ_3.
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
//арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Вариант_1:
int m = 3;
int n = 4;

int[,] a = new int[m, n];

Random random = new Random();
for (int i = 0; i < m; i++)
      for (int j = 0; j < n; j++)
            a[i, j] = random.Next(0, 10);

for (int i = 0; i < m; i++)
{
      for (int j = 0; j < n; j++)
            Console.Write($"{a[i, j],3}");
      Console.WriteLine();
}
Console.WriteLine();

void SrArifmNums(int m, int n)
{
      for (int j = 0; j < n; j++)
      {
            double sum = 0;
            for (int i = 0; i < m; i++)
            {
                  sum += a[i, j];
            }
            Console.Write($"{Math.Round(sum / m, 2)}; ");
      }
}
SrArifmNums(m, n);
Console.WriteLine();

//Вариант_2 от преподавателя:
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

void ArithmeticMean(int[,] arr)
{
      int row = arr.GetLength(0);
      int column = arr.GetLength(1);
      double res;

      for (int i = 0; i < column; i++)
      {
            res = 0;
            for (int j = 0; j < row; j++) res += arr[j, i];
            Console.Write($"{Math.Round(res / row, 2)}; ");
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

ArithmeticMean(mass);



