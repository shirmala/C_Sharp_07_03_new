// Задача 1_3 Вывести на экран числа от -N до N
//Супер-решение
Console.WriteLine("Ввести  N");
int N = int.Parse(Console.ReadLine()!);

int count = -N;
while (count!= N)
{
      Console.WriteLine($"{count}");
      if (N>0) count +=1;
      else count -=1;
      }
Console.WriteLine($"{count}");
Console.WriteLine();

//Мое решениею Некачественное
/*
Console.WriteLine("Ввести положительное число N");
int N = int.Parse(Console.ReadLine()!);

int count = -N;
while (count <= N)
{

      Console.WriteLine(count);
      {
            count++;
      }
}
Console.WriteLine();

Console.WriteLine("Ввести отрицательное число K");
int K = int.Parse(Console.ReadLine()!);

int i = -K;
while (i >= K)
{
      Console.WriteLine(i);
      {
            i--;
      }
}
Console.WriteLine();
*/