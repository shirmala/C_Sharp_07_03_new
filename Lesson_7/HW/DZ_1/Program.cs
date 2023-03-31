// Задача DZ_1.
//Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2

// Вариант_1: программы с вещественными числасми:
double[,] Random2DMassiv(int m, int n, int from = 10, int to = 20)
{
      double[,] a = new double[n, m];
      Random n_new = new Random();
      for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                  a[i, j] = Math.Round(n_new.NextDouble() * (to - from) + from, 2);
      //a[i, j] = n_new.Next(from, to+1);
      return a;
}
void Print2DMassiv(double[,] a)
{
      for (int i = 0; i < a.GetLength(0); i++)
      {
            for (int j = 0; j < a.GetLength(1); j++)
                  Console.Write($"{a[i, j],8}");
            Console.WriteLine();
      }
}
double[,] a = Random2DMassiv(3, 4);
Print2DMassiv(a);

/*
//Вариант_2: с целыми числами:
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
*/


//Вариант_3 от преподаваателя:

void Print(double[,] arr)
{
      int row_size = arr.GetLength(0);
      int column_size = arr.GetLength(1);

      for (int i = 0; i < row_size; i++)
      {
            for (int j = 0; j < column_size; j++)
                  Console.Write($" {arr[i, j],6} ");
            Console.WriteLine();
      }
      Console.WriteLine();
}
double[,] MassNums(int row, int column, int from, int to)
{
      double[,] arr = new double[row, column];
      Random n_new = new Random();

      for (int i = 0; i < row; i++)
            for (int j = 0; j < column; j++)
                  arr[i, j] = Math.Round(n_new.NextDouble() * (to - from) + from, 2);
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

double[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);



