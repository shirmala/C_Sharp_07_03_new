// Задача 1_1 Напишите программу, которая на вход принимает
// два числа и проверяет является ли одно из 
//них квадратом второго 


int a = 0;
int b = 0;

Console.WriteLine("Введите число a");
a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b");
b = int.Parse(Console.ReadLine()!);

if (a * a == b)
{
      Console.WriteLine($"{b} является квадратом {a}");
}
else Console.WriteLine($"{b} не является квадратом {a}");

if (b * b == a)
{
      Console.WriteLine($"{a} является квадратом {b}");
}
else Console.WriteLine($"{a} не является квадратом {b}");

