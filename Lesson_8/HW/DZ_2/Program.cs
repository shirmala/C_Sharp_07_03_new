//Задача DZ_2.
/*
Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[,] MassNumsa(int rowa, int columna, int froma, int toa)
{
      int[,] arr = new int[rowa, columna];

      for (int i = 0; i < rowa; i++)
            for (int j = 0; j < columna; j++)
                  arr[i, j] = new Random().Next(froma, toa);
      return arr;
}
void NumberRMinSum(int[,] arr)
{
      int a = arr.GetLength(0);
      int b = arr.GetLength(1);
      int minR = 0;
      int minSumR = 0;
      int sumR = 0;
      for (int i = 0; i < arr.GetLength(1); i++)
      {
            minR += arr[0, i];
      }
      for (int i = 0; i < arr.GetLength(0); i++)
      {
            for (int j = 0; j < arr.GetLength(1); j++)
                  sumR += arr[i, j];
            if (sumR < minR)
            {
                  minR = sumR;
                  minSumR = i;
            }
            sumR = 0;
      }
      Console.Write($"{minSumR + 1} Строка с наименьшей суммой элементов");
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
NumberRMinSum(massa);

/*
//Вариант_2 от преподавателя:
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
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

int[] SumNum(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[] all_nums = new int[row];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            all_nums[i] += arr[i, j];
        }
    }
    return all_nums;
}

void FindMin(int[] arr)
{
    int min_ind = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[min_ind]) min_ind = i;
    }
    Console.WriteLine($"Sum of elements: {arr[min_ind]}, line: {min_ind + 1}");
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

int[] mass_sum = SumNum(mass);
FindMin(mass_sum);
*/


