//DZ_3. Напишите программу, которая на вход принимает число и
// выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("Введите число");
int a=int.Parse(Console.ReadLine()!);

if (a%2==0) Console.WriteLine ("Четное");
if (a%2!=0) Console.WriteLine ("Нечетное");

// Решение от преподавателя

Console.WriteLine("Введите число");
int b=int.Parse(Console.ReadLine()!);
if (b%2 ==0)
{
Console.WriteLine( "Четное");
}
else 
{
Console.WriteLine ("Нечетное");
}
