
//Задача DZ_1

//Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void Print(int[] arr)
{
      int size = arr.Length;
      for (int i = 0; i < size; i++)
            Console.Write($"{arr[i]}   ");
      Console.WriteLine();
}

int[] ThreeDigitMass(int size, int from, int to)
{
      int[] arr = new int[size];

      for (int i = 0; i < size; i++)
            arr[i] = new Random().Next(from, to + 1);
      return arr;
}
void CountEvenNumber(int[] arr)
{
      int count = 0;
      for (int i = 0; i < arr.Length; i++)
      {
            if (arr[i] % 2 == 0)
                  count++;
      }
      Console.WriteLine($"{count} четных чисел");
}
int num = 8; //int.Parse(Console.ReadLine()!);
int start = 100; //int.Parse(Console.ReadLine()!);
int stop = 1000;//int.Parse(Console.ReadLine()!);

int[] mass = ThreeDigitMass(num, start, stop);
Print(mass);
CountEvenNumber(mass);
