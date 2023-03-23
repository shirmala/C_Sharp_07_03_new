<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");






//https://docs.microsoft.com/en-us/dotnet/api/system.random.nextdouble?view=net-6.0
//https://ru.stackoverflow.com/questions/1254105/%D0%9A%D0%B0%D0%BA-%D1%81%D0%B3%D0%B5%D0%BD%D0%B5%D1%80%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D1%82%D1%8C-%D1%81%D0%BB%D1%83%D1%87%D0%B0%D0%B9%D0%BD%D0%BE%D0%B5-%D0%B4%D1%80%D0%BE%D0%B1%D0%BD%D0%BE%D0%B5-%D1%87%D0%B8%D1%81%D0%BB%D0%BE-%D0%B8%D0%B7-%D0%B8%D0%BD%D1%82%D0%B5%D1%80%D0%B2%D0%B0%D0%BB%D0%B0
=======
﻿// Задача DZ_3.
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

>>>>>>> 5_Lesson
