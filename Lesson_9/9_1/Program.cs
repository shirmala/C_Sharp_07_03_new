//Задача 9_1.
/*
Задайте значения M и N. Напишите программу, которая
рекурсивно выведет все натуральные числа в  промежутке
от M до N.
M = 1, N = 5  > 1,2,3,4,5
M = 4, N = 8  > 4,6,7,8
*/
int M = GetUserNumber("  Введите M");
int N = GetUserNumber("  Введите N");
PrintN(M, N);
Console.WriteLine();

int GetUserNumber(string name)
{
      int number = 0;
      Console.Write($" Please enter {name}:");
      number = int.Parse(Console.ReadLine()!);
      return number;
}
void PrintN(int begin, int end)
{
      if (begin - 1 == end)
      {
            return;
      }

      PrintN(begin, end - 1);
      Console.Write($"{end}   ");
}
