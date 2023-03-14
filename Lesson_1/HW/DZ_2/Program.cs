// DZ_2. Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.
/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.WriteLine("Введите три числа");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

if (a > b)
{
      if (a > c) Console.WriteLine($"Максимальное {a}");
      if (a < c) Console.WriteLine($"Максимальное {c}");
}
if (a < b)
{
      if (b > c) Console.WriteLine($"Максимальное {b}");
      if (b < c) Console.WriteLine($"Максимальное {c}");
}
*/
//Решение от преподавателя
//Очень понравилось это решение. Гениальное!

Console.WriteLine("Введите три числа");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
if (a<b)
{
a=b;
}
if (a<c)
{
a=c;
}
Console.WriteLine ($"число {a} самое большое");
