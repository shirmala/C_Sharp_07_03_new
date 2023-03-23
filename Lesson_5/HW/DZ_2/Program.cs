
//Задача DZ_2
//Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

void Print(int[] arr)
{
      int size = arr.Length;
      for (int i = 0; i < size; i++)
            Console.Write($"{arr[i]} ");
      Console.WriteLine();
}
int[] OddPositionMass(int size, int from, int to)
{
      int[] arr = new int[size];

      for (int i = 0; i < size; i++)
            arr[i] = new Random().Next(from, to + 1);
      return arr;
}
void CountSumOddNumber(int[] arr)
{
      int sum = 0;
      for (int i = 0; i < arr.Length; i++)
      {
            if (i % 2 == 0)
                  sum = sum + arr[i];
      }
      Console.WriteLine($"{sum} сумма эл на нечетных позициях");
}
int num = 8;//int.Parse(Console.ReadLine()!);
int start = 0; //int.Parse(Console.ReadLine()!);
int stop = 10;// int.Parse(Console.ReadLine()!);

int[] mass = OddPositionMass(num, start, stop);
Print(mass);
CountSumOddNumber(mass);
