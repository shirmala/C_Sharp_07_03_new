//Задача 4_2.
//Напишите программу, которая принимает на вход число N
//и выдает произведение чисел от 1 до N

//Моу решение:
//Вариант 1:ввод числа в программе
int MultiNum(int n)
{
      if (n == 1) return 1;
      else
            return MultiNum(n - 1) * n;
}
Console.WriteLine(MultiNum(5));

//Вариант 2:ввод числа в терминале
int MultiN(int n)
{
      if (n == 1) return 1;
      else
            return MultiN(n - 1) * n;
}
int val = int.Parse(Console.ReadLine()!);
MultiN(val);
Console.WriteLine(MultiN(val));

//Вариант 3 : на семинаре со счетчиком
int MultiplyNumbers(int n)
{
      int multi = 1;
      for (int i = 1; i <= n; i++)
      {
            multi = multi * i;
      }
      return multi;
}
int v = int.Parse(Console.ReadLine()!);
Console.WriteLine(MultiplyNumbers(v));

