//Задача DZ_2.
//Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

//Вариант_1 от преподавателя:
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
string FindElement(int[,] arr, int f, int s)
{
      int row = arr.GetLength(0);
      int column = arr.GetLength(1);

      if (f > row || f <= 0 || s > column || s <= 0)
            return $"{f} {s} -> not in the array";
      return $"arr[{f}, {s}] = {arr[f - 1, s - 1]} -> is in the array";
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

Console.Write("Enter the line position: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Enter the column position: ");
int second = int.Parse(Console.ReadLine()!);

string answer = FindElement(mass, first, second);
Console.WriteLine(answer);

/*
//Вариант_2: с одномерным массивом с целыми числами
int[] RandomIntMassiv(int size, int min, int max)
{
      int[] a = new int[size];
      Random random = new Random();
      for (int i = 0; i < size; i++)
            a[i] = random.Next(min, max);
      return a;
}
void Print(int[] a)
{
      for (int i = 0; i < a.Length; i++)
            System.Console.Write($"{a[i],5}");
}
int[] n = RandomIntMassiv(10, -10, 10);
int j = 0;
int find = 5;
Print(n);
Console.WriteLine();
while (j < n.Length && n[j] != find) j++;
if (j == n.Length)
      Console.WriteLine($" Element {find} not found");
else
      Console.WriteLine($" Element  {find} found at {j}");
*/

