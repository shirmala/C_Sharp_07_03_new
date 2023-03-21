// Задача DZ_2.
//Напишите программу, которая принимет на вход число и
//и выдает сумму цифр в числе

//Вариант_1 от преподавателя:
int SumNums_1(int num)
{
      int n_sum = 0;
      while (num > 0)
      {
            n_sum += num % 10;
            num /= 10;
      }
      return n_sum;
}
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNums_1(num_1));

//Вариант_2 от преподавателя:
int SumNums_2(int num)
{
      int n_sum = 0;
      for (; num != 0; num /= 10)
            n_sum += num % 10;
      return n_sum;
}
int num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNums_2(num_2));

// Вариант с рекурсией:
Console.WriteLine("Введите число ");
Console.WriteLine();

int SumDigits(int a)
{
      if (a < 10) return a;
      else return SumDigits(a / 10) + a % 10;
}
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(SumDigits(b));


