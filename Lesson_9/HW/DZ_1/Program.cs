//Задача DZ_1.
/*Задайте значения M и N. Напишите программу, которая выведет все чётные
натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

void AllEvenNumbers(int M, int N)
{
      if (M > N) return;
      if (Math.Abs(M % 2) == 1) M += 1;
      Console.Write($"{M},  ");
      AllEvenNumbers(M + 2, N);
}
AllEvenNumbers(-5, -1);
Console.WriteLine();
AllEvenNumbers(4, 11);

/*
// Решение в общем виде:
void che (int m,int n)
{
 if(m>n)  return;
 if (m%2 == 0)
 {
 Console.Write ($"{m}  " );
 }
 che (m+1,n);
 }
che(5,11);
*/
