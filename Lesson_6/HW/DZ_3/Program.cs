//Задача DZ_3.
//Напишите программу, которая будет создавать копию 
//заданного двумерного массива с помощью поэлементного копирования.


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

int[,] CopyMass(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int[,] new_arr = new int[row_size, column_size];
    
    for (int i = 0; i < row_size; i++)    
        for (int j = 0; j < column_size; j++)        
            new_arr[i, j] = arr[i, j];  // Вот суть поэлементного комирования             
    
    return new_arr;
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
int[,] arr_new = CopyMass(mass);
Print(arr_new);

//Вариант_2, полученный методом пробы))):
int[,] Random2DMass(int n, int m, int min = 0, int max = 10)
{
      int[,] a = new int[n, m];
      Random random = new Random();
      for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                  a[i, j] = random.Next(min, max + 1);
      return a;
}
void Print2DMass(int[,] a)
{
      for (int i = 0; i < a.GetLength(0); i++)
      {
            for (int j = 0; j < a.GetLength(1); j++)
                  Console.Write($"{a[i, j],4}");
            Console.WriteLine();
      }
}
void Copy2DMass(int[,] arr)
{
      int size = arr.Length;// 
}
int[,] a = Random2DMass(6, 9);
Print2DMass(a);
Console.WriteLine();
Copy2DMass(a);
Print2DMass(a);
/*
//Вариант_3 из интернета, забавный и 
// примитивно копирует самый простой массив:

using System;
public class Example
{
     public static void Main()
     {
     int[] arr = {5,4,7,2,9,11,12};
     int[] copy = new int[arr.Length];
     for (int i =0;i<arr.Length;i++)
     {
           copy[i] = arr[i];
     }
           Console.WriteLine(String.Join (",",copy));
     }
}

*/
