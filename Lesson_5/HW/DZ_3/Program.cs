//Задача DZ_3.
//Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
void Print(int[] arr)
{
      int size = arr.Length;
      for (int i = 0; i < arr.Length; i++)
            System.Console.Write($"{arr[i]}    ");
}
int[] MaxMinIntArray(int size, int from, int to)
{
      int[] arr = new int[size];
      for (int i = 0; i < size; i++)
            arr[i] = new Random().Next(from, to);
      return arr;
}
double Max(int[] a)
{
      int m = a[0];
      for (int i = 1; i < a.Length; i++)
            if (a[i] > m) m = a[i];
      return m;
}
double Min(int[] a)
{
      int m = a[0];
      for (int i = 1; i < a.Length; i++)
            if (a[i] < m) m = a[i];
      return m;
}
int[] a = MaxMinIntArray(10, 0, 10);// выбираю 9 чисел
                                    // от 0 до 10
Print(a);
Console.WriteLine();
Console.WriteLine($"Разница: Max(a)-Min(a) равна");
Console.WriteLine(Max(a) - Min(a));
*/
//Вариант от преподавателя:
void Print(double[] arr)
{
      int size = arr.Length;
      for (int i = 0; i < size; i++)
            Console.Write($"{arr[i]} ");
      Console.WriteLine();
}
double[] MassNums(int size, int from, int to)
{
      double[] arr = new double[size];
      Random n_new = new Random();

      for (int i = 1; i < size; i++)
            arr[i] = Math.Round(n_new.NextDouble() * (to - from) + from, 2);
      return arr;
      
}
void DiffMaxMin(double[] arr)
{
      double n_max = arr[0];
      double n_min = arr[0];

      for (int i = 1; i < arr.Length; i++)
      {
            if (n_max < arr[i])
                  n_max = arr[i];
            else if (n_min > arr[i])
                  n_min = arr[i];
      }
      Console.Write($"Max: {n_max}, min: {n_min}. ");
      Console.WriteLine($"Difference: {n_max} - ({n_min}) = {Math.Round(n_max - n_min, 2)}");
}
// 10, 10, 12

int num = 10;//int.Parse(Console.ReadLine()!);
int start = 1;//int.Parse(Console.ReadLine()!);
int stop = 10; //int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
DiffMaxMin(mass);





