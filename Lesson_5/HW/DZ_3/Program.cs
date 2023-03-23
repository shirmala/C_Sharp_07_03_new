// Задача DZ_3.
//Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

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
int Max(int[] a)
{
      int m = a[0];
      for (int i = 1; i < a.Length; i++)
            if (a[i] > m) m = a[i];
      return m;
}
int Min(int[] a)
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

