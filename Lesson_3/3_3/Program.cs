//Задача 3_3
//Напишите программу, которая 
//принимает на вход число (N) и выдаёт таблицу 
//квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
void  Kvadrat (int N)
{
  int i = 1;
  while (i<= N) 
  {
    Console.WriteLine (i*i);
    i = i+1;
  }
}
int a = int.Parse(Console.ReadLine()!);
Kvadrat (a);
