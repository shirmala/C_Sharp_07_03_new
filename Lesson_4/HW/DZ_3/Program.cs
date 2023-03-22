//Задача DZ_3.
// Напишите программу , которая задает массив из 8 эелементов
//случайными числами и выводит их на экран.
//Оформите оформление массива и вывода в виде функции (пригодится
//в следующих задачах).

//Вариант от преподавателя:
void Print(int[] arr)
{
int size = arr.Length;
for (int i=0;i<size;i++)
Console.Write($"{arr[i]}   ");
Console.WriteLine();
}
int[] EightMass(int size,int from, int to)
{
int[] arr = new int[size];
for (int i=0;i<size;i++)
arr[i] = new Random().Next(from,to +1);
return arr;
}
int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = EightMass(num,start,stop);
Print (mass);

//Вариант_1: 
void FillArray(int[] a)
{
      int length = a.Length;
      int i = 0;
      while (i < length)
      {
            a[i] = new Random().Next(10, 20);
            i++;
      }
}
void PrintArray(int[] a)
{
      int i = a.Length;
      int b = 0;
      while (b < i)
      {
            Console.WriteLine($"{a[b]}   ");
            b++;
      }
}
int[] array = new int[8];// мвссив на 8 элементов
FillArray(array);
PrintArray(array);
Console.WriteLine();


//Вариант_2: выведено на семинаре №4
PrintArrays(MakeArray());
int[] MakeArray()
{
      int[] arr = new int[8];
      for (int i = 0; i < 8; i++)
      {
            arr[i] = GenerateNumber();
      }
      return arr;
}
int GenerateNumber()
{
      int number = new Random().Next(2);
      return number;
}
void PrintArrays(int[] array)
{
      for (int i = 0; i < array.Length; i++)
      {
            Console.WriteLine($"{array[i]}    ");
      }
      Console.WriteLine();
}





