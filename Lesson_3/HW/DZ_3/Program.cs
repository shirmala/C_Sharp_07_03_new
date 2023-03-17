//Задача DZ_3.
//Напишите программу,которая принимает на вход число (N) и 
//выдает таблтцу кубов чисел от 1 до N

//  Вариант 1.
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int i = 1;
for (i = 1; i <= N; i++)
{
  Console.WriteLine($"{i * i * i}");
}

//Вариант 2. Решение от преподавателя


