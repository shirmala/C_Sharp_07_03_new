// Задача 2_1. Напишите программу, которая выводит случайное
// число из отрезка [10,99] и показывает наибольшую цифру числа

int BigNum(int num)
{
      int f = num / 10;
      int s = num % 10;
      if (f > s) Console.WriteLine(f);
      if (f < s) Console.WriteLine(s);
      if (f == s) Console.WriteLine(" Цифры одинаковые");
      return (num);
}
int b_num = new Random().Next(10, 100);
int result = BigNum(b_num);
Console.WriteLine(result);
