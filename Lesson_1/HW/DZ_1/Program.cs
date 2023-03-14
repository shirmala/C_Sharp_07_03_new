
// DZ_1.  Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine ("Введите число a:");
int a=int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите число b:");
int b=int.Parse(Console.ReadLine()!);

if(a > b) System.Console.WriteLine ($"максимальное {a}");
else if (a==b)
{
Console.WriteLine ($"число {a} равняется числу {b}");
}
else
Console.WriteLine ($"максимальное {b}");


