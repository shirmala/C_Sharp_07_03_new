//Задача DZ_3.
//Напишите программу,которая принимает на вход число (N) и 
//выдает таблтцу кубов чисел от 1 до N

//  Вариант 1.
void KubNum (int a)
{
 int i = 1;
for (i = 1; i <= a; i++)
{
  Console.WriteLine($"{i * i * i}");
}
}
int b = int.Parse(Console.ReadLine()!);
KubNum(b);

//Вариант 2. Решение от преподавателя

void Squares (int n)
{
double[]  nums = new double [n];
int index = 0;
Console.Write($"{n}    ");
while(index < n)
{
nums[index] = Math.Pow((index+1),3);
Console.Write($"{nums[index]},   ");
index+=1;
}
Console.WriteLine();
}
Squares(int.Parse(Console.ReadLine()!));// Здорово!!Очень понравилось
